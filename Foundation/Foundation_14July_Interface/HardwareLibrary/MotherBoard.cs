using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareLibrary
{
    public class MotherBoard
    {
        private IHardwareDevice[] devices;
        int arrayLength = 0;

        public MotherBoard(int maxHardwareDevicesSupported)
        {
            devices = new IHardwareDevice[maxHardwareDevicesSupported];
        }

        public void AddHardware(IHardwareDevice device)
        {
            devices[arrayLength] = device;
            arrayLength++;
        }

        public string Display()
        {
            string description = null;
            for(int index=0;index<devices.Length;index++)
            {
                description += ", "+devices[index].Describe();
            }
            return description;
        }
    }
}
