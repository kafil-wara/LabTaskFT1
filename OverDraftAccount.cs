using System;
using System.Collections.Generic;
using System.Text;

namespace LabTaskFT1
{
    class OverDraftAccount : Account
    {
        private double overdraft = 0;

        public OverDraftAccount(string name, string id, double balance) : base(name, id, balance)
        {

        }
        override public void transaction(double amount)
        {
            if (amount > balance)
            {
                overdraft = balance * 0.15;
                balance = balance + overdraft;
                if (amount <= balance)
                {
                    this.balance = this.balance - amount;
                    Console.WriteLine("Transaction Successful!!!" + Environment.NewLine);
                    Console.WriteLine(name + " has a due of " + overdraft + " Taka");
                }
                else
                    Console.WriteLine("Transaction exceeds loan limit!" + Environment.NewLine);
            }
            else
                this.balance = this.balance - amount;
        }
        override public void ShowInfo()
        {
            Console.WriteLine("Name :" + name + Environment.NewLine + "ID :" + id + Environment.NewLine + "Balance :" + balance + Environment.NewLine);

        }
    }
}
