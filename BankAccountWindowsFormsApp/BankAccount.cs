using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountWindowsFormsApp
{
    internal class BankAccount
    {
        int summa = 0;
        public void Deposit(int amount)
        {
            summa = summa + amount;
        }
        public void Withdraw(int amount)
        {
            if(summa - amount < 0)
            Console.WriteLine("Du har inte tillräckligt med pengar!");
            else
            {
                summa = summa - amount;
            }
            
        }
        public int GetBalance()
        {
            return summa;
        }
    }
}
