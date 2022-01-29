using System;

namespace Input_3;

class Program
{
    public static void calcNext(int num)
    {
        for (int i = num + 1; i < num + 8; i++)
        {
            Console.Write(i + ", ");
        }
        Console.Write(num + 8);
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("Enter number ");
        int x = Convert.ToInt32(Console.ReadLine());
        Program.calcNext(x);

    }
}
