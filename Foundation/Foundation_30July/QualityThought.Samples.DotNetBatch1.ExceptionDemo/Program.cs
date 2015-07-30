using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityThought.Samples.DotNetBatch1.ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            string input = Console.ReadLine();

            try
            {
                int value = int.Parse(input);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid input");
            }
            
        }
    }
}
