using System;
using System.Collections.Generic;
using System.Text;

namespace LabTaskFT1
{
    abstract class Account
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public Account(string name, string id, double balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
        }

        abstract public void ShowInfo();

        abstract public void transaction(double amount);

    }
}
