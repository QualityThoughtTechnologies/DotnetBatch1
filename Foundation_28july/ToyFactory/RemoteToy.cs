using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    class RemoteToy:IToy,IRemoteWork
    {
        bool isStarted = false;
        bool isRemoteControlled = false;
        public void ControlUsingRemote()
        {
            isRemoteControlled = true;
        }

        public void MakeSound()
        {
            if (isStarted)
            {
                Console.Write("Remote Toy making sound");
                if(isRemoteControlled)
                {
                    Console.WriteLine(" & is operated by remote");
                }
                else
                {
                    Console.WriteLine();
                }
            }
               
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
