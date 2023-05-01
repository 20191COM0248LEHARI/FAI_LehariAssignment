using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lehari_assignment1
{
    class Assignment11
    {
        public static void interestCalculator(int principal,double year,double rate)
        {
            double interest = principal * year * rate / 100;
            Console.WriteLine($"The interest amount is {interest}");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal amount");
            int principal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the years of deposit");
            double year = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest");
            double rate = double.Parse(Console.ReadLine());
            interestCalculator(principal,year,rate);

        }
    }
}
