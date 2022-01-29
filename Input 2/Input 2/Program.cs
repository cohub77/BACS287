using System;

namespace Input_2;

class Program
{

     public static string[] CalcNums(double x, double y)
    {
        string[] arr = new string[5];
        arr[0] = (x + y).ToString();
        arr[1] = (x - y).ToString();
        arr[2] = (x / y).ToString();
        arr[3] = (x * y).ToString();
        arr[4] = ((int)Math.Pow(x, y)).ToString();    
        return arr;
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        string[] arr = Program.CalcNums(num1, num2);
        Console.WriteLine(num1 + " + " + num2 + " = " + arr[0]);
        Console.WriteLine(num1 + " - " + num2 + " = " + arr[1]);
        Console.WriteLine(num1 + " / " + num2 + " = " + arr[2]);
        Console.WriteLine(num1 + " * " + num2 + " = " + arr[3]);
        Console.WriteLine(num1 + " ^ " + num2 + " = " + arr[4]);

    }
}
