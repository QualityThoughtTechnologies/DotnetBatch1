using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareLibrary
{
    public class Processor:IHardwareDevice
    {

        public Processor()
        {
            Socket = SocketType.ThirtyTwoPin;
        }

        public string Describe()
        {
            return "Processor";

        }
        public SocketType Socket { set; get; }
    }
}
