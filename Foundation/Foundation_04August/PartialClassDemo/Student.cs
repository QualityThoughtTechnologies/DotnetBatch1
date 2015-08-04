using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class Student
    {
        private void Display()
        {
            Console.WriteLine("Display");
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
            Display();
        }
    }
}
