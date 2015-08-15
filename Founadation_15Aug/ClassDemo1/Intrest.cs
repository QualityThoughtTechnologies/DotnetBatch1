using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo1
{
    public class Intrest
    {
        private double principal, rateOfIntrest;
        private int timeInYears;

        /// <summary>
        /// This method will be used to calculate simple intrest
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="rateOfIntrest"></param>
        /// <param name="timeInYears"></param>
        /// <returns></returns>
        public double SimpleIntrest(double principal,double rateOfIntrest, int timeInYears )
        {
            this.principal = principal;
            this.rateOfIntrest = rateOfIntrest;
            this.timeInYears = timeInYears;
            return (principal * rateOfIntrest * timeInYears) / 100;
        }
    }
}
