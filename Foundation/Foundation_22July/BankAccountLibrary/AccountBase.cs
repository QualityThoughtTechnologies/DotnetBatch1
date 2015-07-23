using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public abstract class AccountBase:IAccount
    {
        protected double amount;

        public string BankName
        {
            set;
            get;
        }

        public virtual void WithdrawAmount(double amount)
        {
            this.amount -= amount;
        }

        public virtual void DepositAmount(double amount)
        {
            this.amount += amount;
        }

        public string Name
        {
            set;
            get;
        }

        public string Id
        {
            set;
            get;
        }

        public string Address
        {
            set;
            get;
        }

        public virtual double Balance
        {
            get { return this.amount; }
        }

        public override string ToString()
        {

            return string.Format("Account Id : {0}, Account Name: {1}, Balance {2}", Id, Name, Balance);
        }
    }
}
