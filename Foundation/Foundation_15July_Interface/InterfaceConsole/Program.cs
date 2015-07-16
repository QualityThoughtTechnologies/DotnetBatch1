using DeviceSpecificConsole;
using HardwareLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RAM ram = new RAM();
            Processor processor = new Processor();
            MotherBoard motherBoard = new MotherBoard(5);
            IHardwareDevice audioDevice=new SamsungAudioDevice();
            IHardwareDevice samsungRam = new SamsungRAM();
            motherBoard.AddHardware(ram);
            motherBoard.AddHardware(processor);
            motherBoard.AddHardware(new BatteryHolder());
            motherBoard.AddHardware(samsungRam);
            motherBoard.AddHardware(audioDevice);
            Console.WriteLine(motherBoard.Display());


            //SamsungDevices
            BaseHardwareDevice baseDevice =(BaseHardwareDevice) audioDevice;
            baseDevice.DisplayToConsole();
            //DispalyToConsole(audioDevice);

            baseDevice =(BaseHardwareDevice) samsungRam;
            baseDevice.DisplayToConsole();
            //DispalyToConsole(samsungRam);

        }

        //private static void DispalyToConsole(IHardwareDevice hardwareDevice)
    }
}
