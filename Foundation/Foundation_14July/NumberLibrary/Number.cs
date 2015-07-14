using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLibrary
{
    /// <summary>
    /// This class will have basic number Operations
    /// </summary>
    public class Number
    {

        private int number;

        public Number():this(0)
        {
        }

        public Number(int number)
        {
            this.number = number;
        }

        public int Value
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }

        }

        public bool IsEven()
        {
            if(number>0 && (number%2==0))
            {
                return true;
            }
            return false;

           // return number > 0 && (number % 2 == 0);
        }
    }
}
