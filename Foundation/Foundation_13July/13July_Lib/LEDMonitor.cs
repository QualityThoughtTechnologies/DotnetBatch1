using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10july_02
{
    public class LEDMonitor:Monitor
    {

        public override void Start()
        {
            Console.WriteLine("LED Monitor Started");
        }

        public override void Stop()
        {
            Console.WriteLine("LED Monitor Stopped");

        }

        public override void Identify()
        {
            Console.WriteLine("LED Monitor ");
        }
    }
}
