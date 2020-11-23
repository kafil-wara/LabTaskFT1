using System;
using System.Collections.Generic;
using System.Text;

namespace LabTaskFT1
{
    class SavingsAccount : Account
    {
        int trans = 0;

        public SavingsAccount(string name, string id, double balance) : base(name, id, balance)
        {

        }

        override public void transaction(double amount)
        {

            if (trans >= 5)
            {
                Console.WriteLine("Sorry! Can't do anymore transactions with this account" + Environment.NewLine);
            }
            else if (this.balance - amount < 500)
            {
                Console.WriteLine("Insufficient Balance! Total balance after this transaction will be below $500" + Environment.NewLine);
            }
            else
            {
                this.balance = this.balance - amount;
                trans++;
            }

        }
        override public void ShowInfo()
        {
            Console.WriteLine("Name :" + name + Environment.NewLine + "ID :" + id + Environment.NewLine + "Balance :" + balance + Environment.NewLine);

        }
    }
}
