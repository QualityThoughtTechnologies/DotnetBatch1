using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30June_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;
            Console.WriteLine("Please enter a value");
            entry = int.Parse(Console.ReadLine());
            int factorial = 1;
            int currentNumber=entry;
            while(currentNumber>=2)
            {
                factorial *= currentNumber;
                currentNumber--;
            }
            Console.WriteLine("Factorial is " + factorial);
        }
    }
}
