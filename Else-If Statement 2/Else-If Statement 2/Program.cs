using System;

namespace Input_3;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a grade %");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
       
            if (x >= 90)
            {
                Console.WriteLine(x + "% is an A.");
            }
            else if(x >= 80)
            {
            Console.WriteLine(x + "% is a B.");
            }
            else if (x >= 70)
            {
            Console.WriteLine(x + "% is a C.");
            }
            else if (x >= 60)
            {
            Console.WriteLine(x + "% is a D.");
            }
            else
            {
            Console.WriteLine(x + "% is an F.");
            }
    }
}