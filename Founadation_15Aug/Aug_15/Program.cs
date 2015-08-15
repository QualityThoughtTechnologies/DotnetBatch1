using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Enter input");
                int number = int.Parse(Console.ReadLine());
                bool isPrime = true;
                for (int index = 2; index < number; index++)
                {
                    if (number % index == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }

                Console.WriteLine("Do you want to continue Y/N");
                input = Console.ReadLine();

            } while (input=="y" || input=="Y");
        }
    }
}
