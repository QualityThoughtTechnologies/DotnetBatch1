using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10july_02
{
    public class Computer
    {

        private Monitor monitor;
        private InputDevice keyboard;
        private Processor cpu;

        
        public Computer(Monitor monitor, Processor cpu, InputDevice keyboard)
        {
            this.monitor = monitor;
            this.cpu = cpu;
            this.keyboard = keyboard;
        }

        [Obsolete]
        public void Describe()
        {

            Describe(false);
        }
        public void Describe(bool isAdditionalLoggingRequired)
        {
            if(isAdditionalLoggingRequired)
            {
                Console.WriteLine("Describe Started");
            }
            

            monitor.Start();
            cpu.Identify();
            keyboard.Identify();
            if (isAdditionalLoggingRequired)
                Console.WriteLine("Describe In Progress");
            monitor.Identify();
            monitor.Stop();
            if (isAdditionalLoggingRequired)
                Console.WriteLine("Describe Completed");
        }


        public Monitor Monitor
        {
            set
            {
                this.monitor = value;
            }
           
        }
    }
}
