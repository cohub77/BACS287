using System;

namespace Input_3;

class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("Enter a number");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        program.calc(x);
        Console.WriteLine("Enter a number");
        x = Convert.ToDouble(Console.ReadLine());
        program.calc(x);
    }
    public void calc(double x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("Next 3 divisible by 2 are " + (x + 2) + ", " + (x + 4) + ", " + (x + 6));
            }
            if (x % 3 == 0)
            {
                Console.WriteLine("Next 3 divisible by 3 are " + (x + 3) + ", " + (x + 6) + ", " + (x + 9));
            }
            if (x % 5 == 0)
            {
                Console.WriteLine("Next 3 divisible by 5 are " + (x + 5) + ", " + (x + 10) + ", " + (x + 15));
            }         
            if (x % 7 == 0)
            {
                Console.WriteLine("Next 3 divisible by 7 are " + (x + 7) + ", " + (x + 14) + ", " + (x + 21));
            }
            if (x % 8 == 0)
            {
                Console.WriteLine("Next 3 divisible by 8 are " + (x + 8) + ", " + (x + 16) + ", " + (x + 24));
            }
            if (x % 13 == 0)
            {
                Console.WriteLine("Next 3 divisible by 13 are " + (x + 13) + ", " + (x + 26) + ", " + (x + 39));
            }
        }
    
}