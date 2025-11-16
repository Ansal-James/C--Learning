using System;

class PositiveNegative
{
    static void Main(string[] args)
    {
        Console.Write("Enter a Number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num == 0)
        {
            Console.WriteLine("The Number is Zero ");
        }else if (num > 0)
        {
            Console.WriteLine("The Number is Positive ");
        }else
        {
            Console.WriteLine("The Number is Negative ");
        }
    }
}