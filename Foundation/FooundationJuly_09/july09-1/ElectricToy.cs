using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace july09_1
{
    class ElectricToy:Toy
    {
        public override void Run()
        {
            isAnimal = false;
            Console.WriteLine("Run using remote");
            
        }

        public new void MakeSound()
        {
            Console.WriteLine("Electric Toy Making Sound");
        }
    }
}
