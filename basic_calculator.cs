using System;
class Test
{
    public static void Main(string[] args)
    {
        int num1, num2;
        char Operation;
        Console.Write("Input Operation (+,-,*,/): ");
        Operation = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter first Number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        switch(Operation)
        {
            case '+' :
                Console.WriteLine($"{num1} + {num2} =   {num1+num2}");
                break;
            case '-' :
                Console.WriteLine($"{num1} - {num2} =   {num1 - num2}");
                break;
            case '*' :
                Console.WriteLine($"{num1} * {num2} =   {num1 * num2}");
                break;
            case '/' :
                if(num2 != 0)
                {
                    Console.WriteLine($"{num1} / {num2} =   {num1 / num2}");
                }
                else
                {
                    Console.WriteLine($"Can not devaided Zero");
                }
                break;
         default:
                Console.WriteLine($"Invalid Operation");
                break;

        };

    }
}