using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30june_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;
            if (entry>2)
            {
                Console.WriteLine("Please enter a value");
                entry = int.Parse(Console.ReadLine());

                int currentNumber = 2;
                bool isPrime = true;
                while (currentNumber < entry)
                {
                    if (entry % currentNumber == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    currentNumber++;
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                } 
            }
        }
    }
}
