using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    public interface IRemoteWork:IWork
    {
        void ControlUsingRemote();
    }
}
