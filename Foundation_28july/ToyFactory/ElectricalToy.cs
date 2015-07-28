using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    public class ElectricalToy:IToy,IWork
    {
        bool isStarted = false;

        public void MakeSound()
        {
            if (isStarted)
                Console.WriteLine("Electrical Toy making sound");
            else
                Console.WriteLine("Please Start Toy");
        }

        public void Start()
        {
            isStarted = true;
        }

        public void Stop()
        {
            isStarted = false;
        }
    }
}
