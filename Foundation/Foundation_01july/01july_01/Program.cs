using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01july_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;

            do
            {
                
                Console.WriteLine("Please enter a value. If you wnat to exit enter any negative number");
                entry = int.Parse(Console.ReadLine());
                int sum = 0;
                if (entry>0)
                {
                    for (int currentNo = 1; currentNo < entry; currentNo++)
                    {
                        if ((currentNo % 3 == 0) || (currentNo % 5 == 0))
                        {
                            sum += currentNo;
                        }
                    }
                    Console.WriteLine("Sum is " + sum);  
                }
            } while (entry>0);
        }
    }
}
