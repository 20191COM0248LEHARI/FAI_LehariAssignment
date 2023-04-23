using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lehari_assignment1
{
    class Assignment03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int Size = int.Parse(Console.ReadLine());
            int[] Arr = new int[Size];
            Console.WriteLine("Enter the elements you want to store in the array");
            for(int i=0; i<Size; i++)
            {
                Arr[i]=int.Parse(Console.ReadLine());
                if(Arr[i]%2==0)
                {
                    Console.WriteLine($"The number entered is even - {Arr[i]}");
                }
                else
                {
                    Console.WriteLine($"The number entered is odd - {Arr[i]}");
                }
                
            }
        }
    }
    
}
