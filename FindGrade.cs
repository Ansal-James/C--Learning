using System;

class FindGrade
{
    static void Main(string[] args)
    {
        Console.Write("Enter Your Mark to find your grade : ");
        int mark = Convert.ToInt32(Console.ReadLine());

        if (mark >= 90 && mark <= 100)
        {
            Console.WriteLine("Grade : S ");
        }
        else if (mark >= 80 && mark < 90)
        {
            Console.WriteLine("Grade : A ");
        }
        else if (mark >= 70 && mark < 80)
        {
            Console.WriteLine("Grade : B ");
        }
        else if (mark >= 60 && mark < 70)
        {
            Console.WriteLine("Grade : C ");
        }
        else if (mark >= 50 && mark < 60)
        {
            Console.WriteLine("Grade : D ");
        }
        else if (mark >= 40 && mark < 50)
        {
            Console.WriteLine("Grade : E ");
        }
        else if (mark >= 0 && mark < 40)
        {
            Console.WriteLine("You Failed !");
        }
        else
        {
            Console.WriteLine("Invalid Input !!!!! ");
        }
    }
}
