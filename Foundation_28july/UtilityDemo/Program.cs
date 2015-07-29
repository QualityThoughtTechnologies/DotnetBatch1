using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;

namespace UtilityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double rateOfINtrest1;
            double si1=IntrestUtility.GetSimpleIntrest(1000.0, 1.0, out rateOfINtrest1);
            Console.WriteLine("Simple Intrest is {0} and rate of intrest is {1}",si1,rateOfINtrest1);

            double rateOfIntrest2 = 5;
            double si2 = IntrestUtility.GetSimpleIntrestWithRateOfINtrestEntered(1000.0, 1.0, ref rateOfIntrest2);
            Console.WriteLine("Simple Intrest is {0} and rate of intrest is {1}", si2, rateOfIntrest2);
        }
    }
}
