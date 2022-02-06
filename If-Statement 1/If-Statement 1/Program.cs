using System;

namespace Input_3;

class Program
{

    public static void Divide(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Error cannot divide by 0");
        }
        else
        {
            Console.WriteLine(x + " / " + y + " = " + x / y);
        }
    }

    public static void Main(string[] args)
    {
        int x = 2;
        string z = "R";
        if (x > 2 && z == "R")
        {
            Console.WriteLine("A");
        }
        if (x > 2 || z == "z")
        {
            Console.WriteLine("B");
        }
        if (z >= 2 || z == "R")
        {
            Console.WriteLine("C");
        }
    }
}