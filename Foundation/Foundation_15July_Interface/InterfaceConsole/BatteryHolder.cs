using HardwareLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole
{
    internal class BatteryHolder:IHardwareDevice
    {
        public BatteryHolder()
        {
            Socket = SocketType.SixteenPin;
        }

        public string Describe()
        {
            return "BatteryHolder";

        }
        public SocketType Socket { set; get; }
    }
}
