using _08july_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08July_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTV smartTV = new SmartTV("LG","AC","3G");
            //object test = smartTV;
            smartTV.Log();

            TV tv = smartTV;
            tv.Log();
            
        }
    }
}
