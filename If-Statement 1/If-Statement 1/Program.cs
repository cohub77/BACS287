using System;

namespace Input_3;

class Program
{


    public static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("Enter first number ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number ");
        double y = Convert.ToDouble(Console.ReadLine());
        if (y == 0)
        {
            Console.WriteLine("Error cannot divide by 0");
        }
        else
        {
            Console.WriteLine(x + " / " + y + " = " + x / y);
        }
    }
}
