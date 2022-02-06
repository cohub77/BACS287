using System;

namespace Input_3;

class Program
{


    public static void Main(string[] args)
    {
        Random random = new Random();
        int num = random.Next(10) + 1;
        Program program = new Program();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter guess ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == num)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else if (x > num)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            }
        Console.WriteLine("Correct number was " + num);
    }
}
