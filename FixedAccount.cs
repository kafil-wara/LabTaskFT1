using System;
using System.Collections.Generic;
using System.Text;

namespace LabTaskFT1
{
    class FixedAccount : Account
    {
        private int temp = 0;
        public int tenureyear = 2;
        private int openDate;

        public int OpenDate
        {
            get { return openDate; }
            set { openDate = value; }
        }
        DateTime date = DateTime.Now;

        public FixedAccount(string name, string id, int openDate, double balance) : base(name, id, balance)
        {
            this.name = name;
            this.id = id;
            this.openDate = openDate;
            this.balance = balance;
        }
        override public void transaction(double amount)
        {
            int crdate = DateTime.Now.Year;

            if (crdate - this.openDate <= tenureyear)
            {
                Console.WriteLine("Sorry! The account isn't mature enough for transactions...." + Environment.NewLine);

            }
            else
            {
                if (amount - this.balance > this.balance)
                {
                    Console.WriteLine("Insufficient Balance!" + Environment.NewLine);
                }
                else
                {
                    this.balance = this.balance - amount;
                    Console.WriteLine("Transaction Successful" + Environment.NewLine);
                }

            }

        }
        override public void ShowInfo()
        {
            Console.WriteLine("Name : " + name + Environment.NewLine + "ID : " + id + Environment.NewLine + "Balance : " + balance + Environment.NewLine);
        }
    }
}
