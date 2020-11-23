using System;

namespace LabTaskFT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account s2 = new SavingsAccount("Jesse Pinkman", "5721", 10000);
            s2.transaction(9580);
            Console.WriteLine();
            s2.transaction(5000); // First Transaction
            s2.transaction(1500);
            s2.transaction(2500);
            s2.transaction(700); // Illegal Transaction
            s2.ShowInfo();
            Console.WriteLine();


            FixedAccount f4 = new FixedAccount("Walter White", "1001", 2020, 15000);
            f4.transaction(2000);
            f4.ShowInfo();
            Console.WriteLine();

            SpecialSavingsAccount ss1 = new SpecialSavingsAccount("Gus Fring", "1211", 1000);
            SpecialSavingsAccount ss7 = new SpecialSavingsAccount("Mike", "4200", 5000);

            ss1.transaction(150);
            ss1.transaction(50);
            ss1.transaction(200);
            ss1.transaction(100);
            ss1.transaction(10); // Illegal Transaction

            ss7.transaction(4500); // Illegal Transaction
            ss1.ShowInfo();
            ss7.ShowInfo();
            Console.WriteLine();


            Account od3 = new OverDraftAccount("Skylar White", "7835", 5000);
            od3.transaction(5750);
            od3.ShowInfo();
            Console.WriteLine();
            string userName = Console.ReadLine();

        }
    }
}
