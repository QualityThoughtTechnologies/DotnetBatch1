using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnototherInterfaceExample
{
    interface IMyContainer<T>
    {
        void Add(T t);
        string Display();
    }
}
