using System;

namespace Input_3;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        for (int i = 2; i < 9; i++)
        {
            if (x % i == 0)
            {
                Console.WriteLine(x + " is divisible by " + i);
            }
            else
            {
                Console.WriteLine(x + " is not divisible by " + i);
            }
        }
    }
}