using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo1
{
    /// <summary>
    /// This Class contains methods to perform
    /// basic methods such as finding even, prime, pallindrome etc....
    /// </summary>
    class Number
    {
        public int number;

        /// <summary>
        /// Is Even
        /// </summary>
        /// <returns></returns>
        public bool IsEven()
        {
            bool isEven = (number % 2 == 0);
            return isEven;
        }

        /// <summary>
        /// This method will be used to check whether the number is even
        /// or not
        /// </summary>
        /// <param name="number">any postive integer</param>
        /// <returns>true if even false otherwise</returns>
        public bool IsEven(int number)
        {
            this.number = number;
            return IsEven();
        }

        /// <summary>
        /// This method will be used to find out whether the number is 
        /// prime or not
        /// </summary>
        /// <param name="number">any positive integer</param>
        /// <returns>true if prime false otherwise</returns>
        public bool IsPrime(int number)
        {
            bool isPrime = true;
            for (int index = 2; index < number; index++)
            {
                if (number % index == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        /// <summary>
        /// This method will check the Is Prime For Long
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrimeForLong(ulong number)
        {
            bool isPrime = true;
            for (ulong index = 2; index < number; index++)
            {
                if (number % index == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

    }
}
