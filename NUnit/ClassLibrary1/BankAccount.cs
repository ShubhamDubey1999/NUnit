using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BankAccount
    {
        public int balance { get; set; }
        private readonly ILogBook _logBook;
        public BankAccount(ILogBook logBook)
        {
            balance = 0;
            _logBook = logBook;
        }
        public bool Deposit(int amt)
        {
            _logBook.Message("Deposited");
            balance += amt;
            return true;
        }
         public bool Withdraw(int amt)
        {
            if (amt <= balance)
            {
                balance -= amt;
                return true;
            }
            //balance += amt;
            return false;
        }
        public int GetBalance()
        {
            return balance;
        }

    }
}
