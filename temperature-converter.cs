using System;
class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose 1. Fahrenheit to Celsisus");
        Console.
        WriteLine("Choose 2. Celsisus to Fahrenheit");
        int Choose = Convert.ToInt32(Console.ReadLine());
        switch(Choose)
        {
            case 1:
                Console.Write("Enter Fahrenheit in Temperature: ");
                double Fahrenheit = Convert.ToDouble(Console.ReadLine());
                double Celsisus = (Fahrenheit - 32) / 1.8;
                Console.WriteLine($"Temperature in Celsisus:{Celsisus:F2}");
                break;
            case 2:
                Console.Write("Enter Celsisus in Temperature: ");
                double Cels = Convert.ToDouble(Console.ReadLine());
                double Fahr = Cels * 1.8 + 32;
                Console.WriteLine($"Temperature in Celsisus:{Fahr:F2}");
                break;
            default:
                Console.WriteLine("Invalid Choose");
                break;
             
        };
    }
}