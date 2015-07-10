using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29June_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;
            Console.WriteLine("Please enter a value");
            entry = int.Parse(Console.ReadLine());
            if (entry == 0)
            {
                Console.WriteLine("Red");
            }
            else if (entry == 1)
            {
                Console.WriteLine("Orange");

            }
            else if (entry == 2)
            {
                Console.WriteLine("Green");
            }
            else
            {
                Console.WriteLine("Invalid Entry. Valid Values are 0,1,2");
            }
        }
    }
}
