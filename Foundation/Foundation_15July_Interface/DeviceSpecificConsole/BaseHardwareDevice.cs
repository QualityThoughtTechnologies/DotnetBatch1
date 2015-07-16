using HardwareLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSpecificConsole
{
    public abstract class BaseHardwareDevice:IHardwareDevice
    {
        //public virtual string Describe()
        //{
        //    return "Base Hardware Device";

        //}

        protected string resetButton="Default Reset";

        public abstract string Describe();

        public virtual void DisplayToConsole()
        {
            Console.WriteLine("Base cLASS CONSOLE");
        }


        public virtual bool Reset()
        {
            return false;
        }

        //public abstract bool Reset();

        public SocketType Socket { set; get; }
    }
}
