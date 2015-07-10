using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01july_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value.");
            int entry = int.Parse(Console.ReadLine());
            int orginal = entry;
            int reverse = 0;
            while(entry!=0)
            {
                reverse = (reverse *10)+(entry % 10);
                entry = entry / 10;
            }
            Console.WriteLine(reverse);

            if(reverse==orginal)
            {
                Console.WriteLine("Palindrome");
            }
        }
    }
}
