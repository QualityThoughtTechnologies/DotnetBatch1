using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    public class AnimalToy:IToy
    {
        public void MakeSound()
        {
            Console.WriteLine("Making Sound of an animal");
        }
    }
}
