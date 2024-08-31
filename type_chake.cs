/* using System;
using System.Net.WebSockets;
class Test
{
    public static void Main(string[] args)
    {
        object number;
        number = true;
        string message = number switch
        {
            int => "Integer",
            bool => "Boolean",
            double => "Double",
            char => "Charecter",
            _ => "Unknown Type",
        };
        Console.WriteLine($"{message}");
    }
} */