using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06July_01
{
    class Program
    {
        static void Main(string[] args)
        {
            TV t = new TV();
            t.Log();
            TV tv = new TV("Samsung");
            tv.Log();
            TV myNewTV = new TV("Sony", "DC");
            myNewTV.Log();

            //SmartTV t = new SmartTV();
            //t.Log();
            //SmartTV tv = new SmartTV("Samsung");
            //tv.Log();
            //SmartTV myNewTV = new SmartTV("Sony", "DC");
            //myNewTV.Log();
        }
    }
}
