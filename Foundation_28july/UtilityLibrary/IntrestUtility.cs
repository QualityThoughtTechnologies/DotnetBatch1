using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibrary
{
    public static class IntrestUtility
    {
        public static double GetSimpleIntrest(double principal,double timeInYears,out double rateOfIntrest)
        {
            //assume rate of intrest
            rateOfIntrest = 6.0;
            return (principal * timeInYears * rateOfIntrest) / 100;
        }



        public static double GetSimpleIntrestWithRateOfINtrestEntered(double principal, double timeInYears, ref double rateOfIntrest)
        {
            //assume rate of intrest
            rateOfIntrest--;
            return (principal * timeInYears * rateOfIntrest) / 100;
        }

    }
}
