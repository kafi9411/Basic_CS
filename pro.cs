/* using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryManagementSystem
{
    // Class representing an item in the inventory
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Item(int id, string name, int quantity, double price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Quantity: {Quantity}, Price: {Price:C}";
        }
    }

    class Program
    {
        static List<Item> inventory = new List<Item>();
        static string filePath = "inventory.txt"; // Path for file I/O

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management System");

            LoadInventoryFromFile();

            while (true)
            {
                DisplayMenu();

                int choice = GetValidIntegerInput("Choose an option: ");
                switch (choice)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        ViewItems();
                        break;
                    case 3:
                        UpdateItem();
                        break;
                    case 4:
                        DeleteItem();
                        break;
                    case 5:
                        SaveInventoryToFile();
                        break;
                    case 6:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n--- Inventory Menu ---");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. View Items");
            Console.WriteLine("3. Update Item");
            Console.WriteLine("4. Delete Item");
            Console.WriteLine("5. Save Inventory");
            Console.WriteLine("6. Exit");
        }

        // Add a new item to the inventory
        static void AddItem()
        {
            Console.WriteLine("\n--- Add New Item ---");
            int id = GetValidIntegerInput("Enter Item ID: ");
            string name = GetValidStringInput("Enter Item Name: ");
            int quantity = GetValidIntegerInput("Enter Quantity: ");
            double price = GetValidDoubleInput("Enter Price: ");

            Item newItem = new Item(id, name, quantity, price);
            inventory.Add(newItem);

            Console.WriteLine("Item added successfully!");
        }

        // View all items in the inventory
        static void ViewItems()
        {
            Console.WriteLine("\n--- Inventory Items ---");
            if (inventory.Count == 0)
            {
                Console.WriteLine("No items in inventory.");
            }
            else
            {
                foreach (var item in inventory)
                {
                    Console.WriteLine(item);
                }
            }
        }

        // Update an existing item in the inventory
        static void UpdateItem()
        {
            Console.WriteLine("\n--- Update Item ---");
            int id = GetValidIntegerInput("Enter the ID of the item to update: ");

            Item item = inventory.Find(i => i.Id == id);
            if (item == null)
            {
                Console.WriteLine("Item not found.");
                return;
            }

            string newName = GetValidStringInput("Enter new name (leave empty to keep current): ");
            if (!string.IsNullOrWhiteSpace(newName)) item.Name = newName;

            int newQuantity = GetValidIntegerInput("Enter new quantity (leave empty to keep current): ", false);
            if (newQuantity > 0) item.Quantity = newQuantity;

            double newPrice = GetValidDoubleInput("Enter new price (leave empty to keep current): ", false);
            if (newPrice > 0) item.Price = newPrice;

            Console.WriteLine("Item updated successfully!");
        }

        // Delete an item from the inventory
        static void DeleteItem()
        {
            Console.WriteLine("\n--- Delete Item ---");
            int id = GetValidIntegerInput("Enter the ID of the item to delete: ");

            Item item = inventory.Find(i => i.Id == id);
            if (item == null)
            {
                Console.WriteLine("Item not found.");
                return;
            }

            inventory.Remove(item);
            Console.WriteLine("Item deleted successfully!");
        }

        // Save the inventory to a text file
        static void SaveInventoryToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in inventory)
                {
                    writer.WriteLine($"{item.Id},{item.Name},{item.Quantity},{item.Price}");
                }
            }
            Console.WriteLine("Inventory saved to file successfully.");
        }

        // Load the inventory from a text file
        static void LoadInventoryFromFile()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var data = line.Split(',');
                        int id = int.Parse(data[0]);
                        string name = data[1];
                        int quantity = int.Parse(data[2]);
                        double price = double.Parse(data[3]);

                        Item item = new Item(id, name, quantity, price);
                        inventory.Add(item);
                    }
                }
                Console.WriteLine("Inventory loaded from file.");
            }
        }

        // Helper method to get valid integer input
        static int GetValidIntegerInput(string prompt, bool required = true)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    return result;
                }
                if (!required && string.IsNullOrWhiteSpace(input)) return -1;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Helper method to get valid string input
        static string GetValidStringInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        // Helper method to get valid double input
        static double GetValidDoubleInput(string prompt, bool required = true)
        {
            double result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    return result;
                }
                if (!required && string.IsNullOrWhiteSpace(input)) return -1;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
 */