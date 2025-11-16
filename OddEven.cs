using System;

class OddEven
{
    static void Main(string[] args)
    {
        Console.Write("Enter a Number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num%2 == 0)
        {
            Console.WriteLine("The Number is Even");
        }
        else
        {
            Console.WriteLine("The Number is Odd ");
        }
    }
}
