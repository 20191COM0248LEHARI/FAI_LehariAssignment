using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lehari_assignment1
{
    class Assignment07
    {
        static bool isPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        static void Main(string[] args)
        {
            bool flag = true;

            do
            {
                int number = UIConsole.GetNumber("Enter the number ");
                bool isprime = isPrimeNumber(number);
                Console.WriteLine($"The number entered {number} is a {isprime} prime number ");
                Console.WriteLine("Press any key to clear");
                Console.ReadLine();
                Console.Clear();
                
            } while (flag);


        }
    }
}
