using System;

namespace Input_3;

class Program
{
    public static void Main(string[] args)
    {
        double[] arr = new double[4];
        string[] arr2 = new string[4];
        Console.WriteLine("Enter first name");
        arr2[0] = Console.ReadLine();
        Console.WriteLine("Enter first time in seconds");
        arr[0] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second name");
        arr2[1] = Console.ReadLine();
        Console.WriteLine("Enter second time in seconds");
        arr[1] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter third name");
        arr2[2] = Console.ReadLine();
        Console.WriteLine("Enter third time in seconds");
        arr[2] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter fourth name");
        arr2[3] = Console.ReadLine();
        Console.WriteLine("Enter fourth time in seconds");
        arr[3] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        double m = arr.Min();
        int p = Array.IndexOf(arr, m);
        Console.WriteLine("The fastest time was " + m + " by " + arr2[p]);

    }
}