using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lehari_assignment1
{
    class Assignment04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] Arr = new int[size];
            Console.WriteLine("Enter the numbers which u want to add in the Array");
            for (int i =0; i<size; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("displaying the array elements");
            for (int j=0; j<size; j++)
            {
                Console.Write(Arr[j]);
            }

        }
    }
}
