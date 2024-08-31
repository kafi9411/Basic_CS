/* using System;
using System.Net.WebSockets;
class Test
{
    public static void Main(string[] args)
    {
        int digit;
        Console.WriteLine("Enter any digit: ");
        digit = Convert.ToInt32(Console.ReadLine());

        string message = digit switch
        {
            0 => "Zero",
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            _ => "Invalid Digit"
        };
        Console.WriteLine($"{message}");
      
    }
} */