using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public interface IIdentity
    {
        string Name { set; get; }
        string Id { set; get; }

        string Address { set; get; }
    }
}
