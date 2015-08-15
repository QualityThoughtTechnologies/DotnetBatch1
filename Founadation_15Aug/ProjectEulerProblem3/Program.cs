using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input");
            int number = int.Parse(Console.ReadLine());
            for(int index=2;index<number;index++)
            {
                if(number%index==0)
                {
                    Console.Write(index + " ");
                }
            }
        }
    }
}
