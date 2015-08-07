using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityThought.UtilityLibrary
{
    /// <summary>
    /// This class will contain the Utility Methods for a number
    /// </summary>
    public static class NumberUtility
    {
        /// <summary>
        /// This Method is used to find whether the number is even or odd
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsEven(int number)
        {
            //fix for test case negative.

            if(number<=0)
            {
                throw new ArgumentException("number cannot be less than or equal to zero");
            }

            return (number % 2 == 0);

        }

        public static int IncrementNumber(int number)
        {
            return number + 1; 

        }
    }
}
