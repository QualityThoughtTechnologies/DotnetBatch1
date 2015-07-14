using NumberLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberIndex = 1;
            int maxNumberLimit = 100;
            int[] evenNumbers = new int[maxNumberLimit/2];
            int evenNumbersIndex = 0;
            Number number = new Number();
            int tempINdex = numberIndex;
            for(numberIndex=1;numberIndex<=maxNumberLimit;numberIndex++)
            {
                //Number number = new Number(numberIndex);
                number.Value = numberIndex;
                if(number.IsEven())
                {
                    evenNumbers[evenNumbersIndex] = numberIndex;
                    evenNumbersIndex++;

                }

            }

            Console.WriteLine("Even nubers from {0} to {1} are", tempINdex, maxNumberLimit);
            for(int index=0;index<evenNumbers.Length;index++)
            {
                Console.WriteLine(evenNumbers[index]);
            }
        }
    }
}
