using System;
using System.Collections;
namespace Input_3;
class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        double x = 0;
        Console.WriteLine("Enter 'full' or 'part' for full or part time");
        string y = (Console.ReadLine());
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter a grade");
            x = Convert.ToDouble(Console.ReadLine());
            if (x != -1)
                list.Add(x);
        }
        double sum = 0;
        foreach (double i in list)
            sum += i;
        double average = sum / list.Count;
        Console.WriteLine("Average: " + (average));

        if (average >= 3.5 && y == "full")
        {
            Console.WriteLine("Dean's List");
        }
        else
        {
            Console.WriteLine("Not Dean's List");
        }
    }
}