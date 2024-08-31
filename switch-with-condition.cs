/* using System;
using Microsoft.VisualBasic;
class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case int num when num % 2 == 0:
                Console.WriteLine($"{number} is Even");
                break;
            default:
                Console.WriteLine($"{number} is Odd");
                break;

        };
    }
} */
                // Tarnary Opartor

/* using System;
class Test{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number between 1 to 10: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string result = number switch
        {
            int num when num >= 1 && num <=10  => num % 2 == 0 ? "Even number" : "Odd number",
            _ => "Out of Range"
        };
        Console.Write($"{result}");
    }
} */