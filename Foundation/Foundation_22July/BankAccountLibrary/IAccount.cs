using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public interface IAccount:ITransaction,IIdentity
    {
        string BankName { set; get; }

    }
}
