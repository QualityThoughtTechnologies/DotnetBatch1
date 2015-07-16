using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSpecificConsole
{
    public class SamsungAudioDevice:BaseHardwareDevice
    {
        public SamsungAudioDevice()
        {
            resetButton = "Audio Reset";
        }

        public override string Describe()
        {
            return "Samsung RAM with " + resetButton;
        }

        public override bool Reset()
        {
            return true;
        }

        public override void DisplayToConsole()
        {
            base.DisplayToConsole();
            Console.WriteLine("Audio Device console");
        }
    }
}
