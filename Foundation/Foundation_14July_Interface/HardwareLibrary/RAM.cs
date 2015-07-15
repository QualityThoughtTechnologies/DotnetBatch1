using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareLibrary
{
    public class RAM:IHardwareDevice
    {
        public RAM()
        {
            Socket = SocketType.SixteenPin;
        }

        public string Describe()
        {
            return "RAM";

        }
        public SocketType Socket { set; get; }
    }
}
