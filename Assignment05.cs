using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lehari_assignment1
{
    class Assignment05
    {
        static void Main()
        {
            do
            {
                double firstNum = UIConsole.GetDouble("Enter First Value");
                double secondNum = UIConsole.GetDouble("Enter Second Value");
                string math = UIConsole.GetString("Enter Choice as + -  X or /");
                double result = performOperation(firstNum, secondNum, math);
                Console.WriteLine("The result of the operation is " + result);
                Console.WriteLine("Press any key to clear the screen");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }

        private static double performOperation(double firstNo, double secondNo, string math)
        {
            double result = 0;
            switch (math)
            {
                case "+": result = firstNo + secondNo; break;
                case "-": result = firstNo - secondNo; break;
                case "X": result = firstNo * secondNo; break;
                case "/": result = firstNo / secondNo; break;
                default:
                    break;
            }

            return result;
        }
    }
}
