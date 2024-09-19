/*  using System;
using System.Security.Cryptography;
class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Type total Sum = 'total' Odd Sum ='odd' or Even Sum = 'even' ");
        string number = Convert.ToString(Console.ReadLine());

        int firstNumber, secondNumber;

        Console.WriteLine("Enter minimum number: ");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter maximum number: ");
        secondNumber = Convert.ToInt32(Console.ReadLine());


        switch(number)
        {
            case "total":
                int total = 0;
                for( int i = firstNumber; i <= secondNumber; i++)
                {
                    total = total + i;
                }
                Console.WriteLine($"Total number = {total}");
                break;
            case "even":
                int totalEven = 0;
                for (int i = firstNumber; i <= secondNumber; i++)
                if( i%2 == 0)
                    {
                        {
                            totalEven = totalEven + i;
                        }
                    }               
                Console.WriteLine($"Total Even Number = {totalEven}");
                break;
            case "odd":
                int totalOdd = 0;
                for (int i = firstNumber; i <= secondNumber; i++)
                    if (i % 2 == 1)
                    {
                        {
                            totalOdd = totalOdd + i;
                        }
                    }
                Console.WriteLine($"Total Odd Number = {totalOdd}");
                break;
            default:
                Console.WriteLine("Invalid command");
                break;
            
        };
    }
}  */