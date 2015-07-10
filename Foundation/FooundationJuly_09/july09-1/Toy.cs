using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace july09_1
{
    public class Toy
    {

        protected bool isAnimal;
        public virtual void Run()
        {
            Console.WriteLine("Run Mechanically");
        }

        public void MakeSound()
        {
            Console.WriteLine("Toy Making Sound");

        }
    }
}
