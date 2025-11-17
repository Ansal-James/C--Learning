using System;

class PrimeOrNot
{
    static void Main(string[] args)
    {
        Console.Write("Enter a Number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool flag = true;
        int limit = (int)Math.Sqrt(num);
        if(num < 2)
        {
            Console.WriteLine("Not A Prime !");
            return;
        }
        else
        {
            for (int i = 2; i <= limit; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if(flag == true)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not A Prime !");
            }
        }
    }
}