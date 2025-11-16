using System;

class LargestOfThree
{
    static void Main(string[] args)
    {
        Console.Write("Enter the First Number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Second Number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Third Number : ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("The Greatest Number is " + num1);
        }
        else if (num2 >= num3)
        {
            Console.WriteLine("The Greatest Number is " + num2);
        }
        else
        {
            Console.WriteLine("The Greatest Number is " + num3);
        }
    }
}