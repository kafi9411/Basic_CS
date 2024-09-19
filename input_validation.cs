/* using System;
class Test
{
    public static int CalculateSquare(int number){
        return number * number;
    }
    public static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Enter a number from 1 to 10 and write quit to exit the app");

            string input = Console.ReadLine() ?? "";
            input = input.ToLower().Trim();

            if(input == "quit")
            {
                Console.Write("Thanks for using app. Goodbye!");
                break;
            }

            if (!int.TryParse(input, out int number)) 
            {
                Console.Write("Enter a valid number. Please give a number");
                continue;
            }
            if(!(number >= 1 && number <= 10))
            {
                Console.WriteLine("Not in a range of 1 to 10");
                continue;
            }

            int square = CalculateSquare(number);
            Console.Write($"Square of {number} = {square}");
            Console.ReadKey();
        }
    }
} */