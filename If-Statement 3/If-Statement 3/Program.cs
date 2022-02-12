using System;

namespace Input_3;

class Program
{

    public static void signOf(double x)
    {
        if (x > 0)
        {
            Console.WriteLine("The number is positive");
        }
        else if (x < 0)
        {
            Console.WriteLine("The number is negative");
        }
        else
        {
            Console.WriteLine("The number is 0");
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        double x = Convert.ToDouble(Console.ReadLine());
        signOf(x);
        Console.WriteLine();
        Console.WriteLine("Enter a number");
        x = Convert.ToDouble(Console.ReadLine());
        signOf(x);
    }
}