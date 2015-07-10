using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03July_02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value.");
            int entry = int.Parse(Console.ReadLine());
            
            if (entry > 0)
            {
                
                Number evenNumber = new Number();
                
                if (evenNumber.IsEven(entry))
                {
                    Console.WriteLine("{0} is even", entry);
                }
                else
                {
                    Console.WriteLine("{0} is odd", entry);
                }
            }
        }
    }
}
