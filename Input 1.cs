using System;

namespace Input_1
{
    class Program
    {
        public static int calcSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static float calcAverage(int[] arr)
        {
            float average = 0.0F;
            average = (float)calcSum(arr) / arr.Length;
            return average;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sum: " + Program.calcSum(arr));
            Console.WriteLine("Average: " + Program.calcAverage(arr));
        }
    }
}
