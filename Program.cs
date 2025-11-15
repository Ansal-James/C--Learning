using System;

class ArithmeticOperations
{
    static void Main(string[] args)
    {
        Console.Write("Enter the First Number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Second Number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($" In Addition : {num1 + num2}");
        Console.WriteLine($" In Subtraction : {num1 - num2}");
        Console.WriteLine($" In Division : {num1 / num2}");
        Console.WriteLine($" In Multiplication : {num1 * num2}");

    }
}
