using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareLibrary
{
    public interface IHardwareDevice
    {
        string Describe();

        SocketType Socket { set; get; }


    }
}
