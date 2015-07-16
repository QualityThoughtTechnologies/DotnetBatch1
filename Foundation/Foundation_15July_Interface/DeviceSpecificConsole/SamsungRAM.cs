using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSpecificConsole
{
    public class SamsungRAM:BaseHardwareDevice
    {

        public override string Describe()
        {
            return "Samsung RAM with " + resetButton;
        }

        public override void DisplayToConsole()
        {
            Console.WriteLine("RAM Console");
            base.DisplayToConsole();
        }
    }
}
