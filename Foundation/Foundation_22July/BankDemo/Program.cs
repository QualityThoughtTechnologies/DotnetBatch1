using BankAccountLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
    class Program
    {
        static IList<IAccount> accountList = new List<IAccount>(7);
        static void Main(string[] args)
        {
            IAccount currentAccount = new CurrentAccount();
            currentAccount.Address = "Test";
            currentAccount.Id = "1";
            currentAccount.Name = "Test";
            currentAccount.BankName = "BTest";
            currentAccount.DepositAmount(100000);
            AddAccount(currentAccount);

            IAccount savingsAccount = new SavingsAccount();
            savingsAccount.Address = "Test1";
            savingsAccount.Id = "2";
            savingsAccount.Name = "Test1";
            savingsAccount.BankName = "BTest";
            savingsAccount.DepositAmount(10000);
            AddAccount(savingsAccount);

        }

        static void AddAccount(IAccount account)
        {
            accountList.Add(account);
        }
    }
}
