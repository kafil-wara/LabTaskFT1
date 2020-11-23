using System;
using System.Collections.Generic;
using System.Text;

namespace LabTaskFT1
{
    class SpecialSavingsAccount : Account
    {
        int trans = 0;
        public SpecialSavingsAccount(string name, string id, double balance) : base(name, id, balance)
        {

        }

        override public void transaction(double amount)
        {
            double temp = this.balance * 0.20;
            if (trans >= 5)
            {
                Console.WriteLine("Sorry! Can't do anymore transactions with this account" + Environment.NewLine);
            }
            else
            {
                if (this.balance - amount < temp)
                {
                    Console.WriteLine("Transaction Failed. Reason - Remaining balance will be less than 20% of balance" + Environment.NewLine);
                }
                else
                {
                    this.balance = this.balance - amount;
                }

            }
            trans = trans + 1;
        }
        override public void ShowInfo()
        {
            Console.WriteLine("Name : " + name + Environment.NewLine + "ID : " + id + Environment.NewLine + "Balance : " + this.balance + Environment.NewLine);

        }
    }
}
