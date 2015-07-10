using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29JUne_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;
            switch(entry)
            {
                case 0:
                    Console.WriteLine("Red");
                    break;
                case 1:
                    Console.WriteLine("Orange");
                    break;
                case 2:
                    Console.WriteLine("Green");
                    break;
                default:
                    Console.WriteLine("Invalid Entry. Valid Values are 0,1,2");
                    break;
                    
            }
        }
    }
}
