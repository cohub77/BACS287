using System;

namespace Output_3
{
    class Program
    {
        public static int calcSum(int[] arr) {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static float calcAverage(int[] arr){
            float average = 0.0F;
            average = (float)calcSum(arr) / arr.Length;
            return average;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            int[] arr = { 1, 5, 6, 3, 12, 11, 10, 56, 342, 7 };       
            Console.WriteLine("Sum: " + Program.calcSum(arr));
            Console.WriteLine("Average: " + Program.calcAverage(arr));
        }
    }
}
