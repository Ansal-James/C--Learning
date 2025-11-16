using System;

class LeepYear
{
    static void Main(string[] args)
    {
        Console.Write("Enter a Year You want to check that is a Leep Year : ");
        int year = Convert.ToInt32(Console.ReadLine());

        if((year%4==0 && year%100!=0) || (year%400 == 0))
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not a Leap Year !");
        }
    }
}