using System;

namespace Input_4;

class Program
{
    double pay;
    public Program(double week) {
        pay = week;
    }
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
        }
        return weekPay;
    }
    public Program print(Program program){
        Console.WriteLine("Enter hourly pay");
        double pay = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter hours worked");
        double hours = Convert.ToDouble(Console.ReadLine());
        double weekPay = payCalc(pay, hours);
        program = new Program(weekPay);
        return program;
    }


    public static void Main(string[] args)
    {
    Program program1 = new Program(47);
    print(program1);
    Console.WriteLine("Your total pay for the week is : $" + program1.pay);
    Console.WriteLine();


}
}
