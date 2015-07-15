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
            MotherBoard motherBoard = new MotherBoard(2);
            motherBoard.AddHardware(ram);
            motherBoard.AddHardware(processor);
            Console.WriteLine(motherBoard.Display());
        }
    }
}
