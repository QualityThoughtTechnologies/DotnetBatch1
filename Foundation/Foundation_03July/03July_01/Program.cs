using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03July_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value.");
            int entry = int.Parse(Console.ReadLine());
            if(entry>0)
            {
                if(IsEven(entry))
                {
                    Console.WriteLine("{0} is even", entry);
                }
                else
                {
                    Console.WriteLine("{0} is odd", entry);
                }
            }
            
        }

        static bool IsEven(int entry)
        {
            return entry % 2 == 0;
        }
    }
}
