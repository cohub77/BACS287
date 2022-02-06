using System;

namespace Input_4;

class Program
{

    public static double payCalc(double pay, double hours)
    {
        double weekPay = 0;
        if (hours <= 40)
        {
            weekPay = hours * pay;
        }
        else
        {
            weekPay = (40 * pay) + (hours - 40) * pay * 1.5;
            Console.WriteLine("The number is 0");
        }
        return weekPay;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter hourly pay");
        double pay = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter hours worked");
        double hours = Convert.ToDouble(Console.ReadLine());
        double weekPay = payCalc(pay, hours);
        Console.WriteLine("Your total pay for the week is : $" + weekPay);

    }
}