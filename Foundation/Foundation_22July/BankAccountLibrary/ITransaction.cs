using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public interface ITransaction
    {
        void WithdrawAmount(double amount);
        void DepositAmount(double amount);
    }
}
