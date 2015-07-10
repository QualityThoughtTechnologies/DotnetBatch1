using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01July_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value.");
            int entry = int.Parse(Console.ReadLine());
            int a = 1, b = 2;
            int c = 0;
            int sum = 0;
            while(c<entry)
            {
                if(a%2==0)
                {
                    sum += a;
                }
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine("Sum is " + sum);  
        }
    }
}
