using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03July_02
{
    /// <summary>
    /// This clas is used to find out the even numbers
    /// </summary>
    class Number
    {
        private int entry;

        /// <summary>
        /// This method will identify whether the number is even or odd
        /// </summary>
        /// <param name="entry">This parameter is used to check whether it is even or odd</param>
        /// <returns>true if even false otherwise</returns>
        public bool IsEven(int entry)
        {
            //asigning the argument value to field
            this.entry = entry;
            return entry % 2 == 0;
        }
        /// <summary>
        /// This method will identify whether the number is even or odd
        /// </summary>
        /// <param name="entry">This parameter is used to check whether it is even or odd</param>
        /// <returns>true if even false otherwise</returns>
        public static bool IsEvenNumber(int entry)
        {
            //asigning the argument value to field
                        return entry % 2 == 0;
        }
    }
}
