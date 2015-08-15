using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter input");
            //int number = int.Parse(Console.ReadLine());
            //for (int index = 2; index < number; index++)
            //{
            //    if (number % index == 0)
            //    {
            //        Number indexNumber = new Number();
            //        if(indexNumber.IsPrime(index))
            //        {
            //            Console.Write(index + " ");
            //        }
            //    }
            //}

            ulong number = ulong.Parse(Console.ReadLine());
            for (ulong index = 2; index < number; index++)
            {
                if (number % index == 0)
                {
                    
                    if (Number.IsPrimeForLong(index))
                    {
                        Console.Write(index + " ");
                    }
                }
            }

            Number myNumber = new Number();
            myNumber.number = 107;
            if(myNumber.IsEven())
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Intrest simpleIntrest = new Intrest();
            Console.WriteLine(simpleIntrest.SimpleIntrest(10000.0, 0.25, 5));

            
        }
    }
}
