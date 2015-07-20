using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnototherInterfaceExample
{
    interface IContact
    {
        string Name { set; get; }

        string Phone { set; get; }

        string Email { set; get; }

        string Address { set; get; }
    }
}
