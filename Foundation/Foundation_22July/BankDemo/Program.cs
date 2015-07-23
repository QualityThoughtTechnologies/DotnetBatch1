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
            Display();

            IAccount savingsAccount = new SavingsAccount();
            savingsAccount.Address = "Test1";
            savingsAccount.Id = "2";
            savingsAccount.Name = "Test1";
            savingsAccount.BankName = "BTest";
            savingsAccount.DepositAmount(20000);
            AddAccount(savingsAccount);

            Display();

            IAccount creditCardAccount = new CreditCardAccount();
            creditCardAccount.Address = "Test2";
            creditCardAccount.Id = "3";
            creditCardAccount.Name = "Test2";
            creditCardAccount.BankName = "BTest";
            creditCardAccount.DepositAmount(300000);
            AddAccount(creditCardAccount);
            List<IAccount> tempList=new List<IAccount>();
            tempList.AddRange(accountList);
            Display();
            accountList.RemoveAt(1);
            Console.WriteLine();
            Console.WriteLine();
            Display();

            Console.WriteLine();
            Console.WriteLine();

            accountList.Remove(creditCardAccount);
            Display();
            accountList.Clear();
            Display();

            accountList = tempList;
            Display();

            
        }

        private static void Display()
        {
            Console.WriteLine("Number of Acounts are :" + accountList.Count);

            foreach (IAccount account in accountList)
            {
                Console.WriteLine(account);
            }
        }



        static void AddAccount(IAccount account)
        {
            accountList.Add(account);
        }
    }
}
