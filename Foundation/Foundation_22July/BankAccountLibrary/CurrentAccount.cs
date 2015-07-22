using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public class CurrentAccount:AccountBase
    {
        public override void DepositAmount(double amount)
        {
            base.DepositAmount(amount);
            Console.WriteLine("Send SMS");
        }

        public override void WithdrawAmount(double amount)
        {
            base.WithdrawAmount(amount);
            Console.WriteLine("Send SMS");
        }
    }
}
