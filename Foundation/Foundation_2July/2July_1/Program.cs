using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2July_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Name");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter Institute Name");
            string instituteName = Console.ReadLine();
            string message = "Hi " + studentName + " This is " + instituteName+". We would like you ("+studentName+") to visit once";
            Console.WriteLine(message);
            string formattedMessage = string.Format("Hi {0} This is {1}. We wouild like you({0}) to visit once", studentName, instituteName);
            Console.WriteLine(formattedMessage);
            
            

        }
    }
}
