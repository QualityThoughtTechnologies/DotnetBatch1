using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public class SavingsAccount:AccountBase
    {
        public override void WithdrawAmount(double amount)
        {
            if(this.amount<amount)
            {
                Console.WriteLine("Invalid Transaction");
            }
            else
            {
                base.WithdrawAmount(amount);
            }
            
        }
    }
}
