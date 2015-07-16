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
            MotherBoard motherBoard = new MotherBoard(3);
            motherBoard.AddHardware(ram);
            motherBoard.AddHardware(processor);
            motherBoard.AddHardware(new BatteryHolder());
            Console.WriteLine(motherBoard.Display());
        }
    }
}
