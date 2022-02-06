using System;

namespace Input_3;

class Program
{
    public static void calcNext(int x, int y, int z)
    {
        
        int sum = x + y + z;
        for (int i = sum - 1; i > sum - 8; i--)
        {
            Console.Write(i + ", ");
        }
        Console.Write(sum - 8);
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("Enter first number ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number ");
        int z = Convert.ToInt32(Console.ReadLine());
        int sum = x + y + z;
        Console.WriteLine(x + " + " + y + " + " + z + " = " + sum);
        Program.calcNext(x, y, z);

    }
}
