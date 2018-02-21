using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    public class Account
    {
        protected string accNumber;
        protected Customer accHolderName;
        protected double balance;
        private static double interestRate;


        //constructor
        public Account(string accNumber, Customer accHolderName, double balance)
        {
            this.accNumber = accNumber;
            this.accHolderName = accHolderName;
            this.balance = balance;
        }

        public Account() : this("000-00-000", new Customer(), 0.00)
        {
        }


        //property
        public double Balance
        {
            get
            {
                return balance;
            }

            //set
            //{
            //    if(value>0)
            //        balance = value;
            //}
        }


        public string AccNumber
        {
            get
            {
                return accNumber;
            }
        }

        public Customer c
        {
            get
            {
                return accHolderName;
            }
        }


        //methods
        public bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                return true;
            }

            else
                Console.Error.WriteLine("Not enough funds!");
            return false;

        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public bool TransferTo(double amount, Account AccountToTransfer)
        {
            if (Withdraw(amount))
            {
                AccountToTransfer.Deposit(amount);
                return true;
            }
            else
            {
                Console.Error.WriteLine("Transfer unsuccesful");

                return false;
            }
        }

        public double CalculateInterest()
        {
            return (balance * (interestRate / 100));
        }

        public void CreditInterest()
        {
            double interest = CalculateInterest();
            Deposit(interest);
        }

        public void Show()
        {
            Console.WriteLine("Account Number: {0}, Acc Holder Name: {1}, Balance: {2}", accNumber, accHolderName.Show(), balance);
        }


    }


    public class SavingsAccount : Account
    {
        private static double interestRate = 1;
        public SavingsAccount(string accnum, Customer accholder, double balance)
            : base(accnum, accholder, balance)
        {

        }

        public new double CalculateInterest()
        {
            return (balance * (interestRate / 100));
        }

        public new void CreditInterest()
        {
            double interest = CalculateInterest();
            Deposit(interest);
        }

    }

    public class CurrentAccount : Account
    {
        private static double interestRate = 0.25;
        public CurrentAccount(string accnum, Customer accholder, double balance)
            : base(accnum, accholder, balance)
        {

        }

        public new double CalculateInterest()
        {
            return (balance * (interestRate / 100));
        }

        public new void CreditInterest()
        {
            double interest = CalculateInterest();
            Deposit(interest);
        }

    }

    public class OverDraftAccount : Account
    {
        private static double interestRate = 0.25;
        private static double negInterestRate = 6;
        public OverDraftAccount(string accnum, Customer accholder, double balance)
            : base(accnum, accholder, balance)
        {

        }

        public new double CalculateInterest()
        {
            if (balance < 0)
            {

                return (balance * (negInterestRate / 100));
            }
            else
            {

                return (balance * (interestRate / 100));
            }
        }

        public new void CreditInterest()
        {
            double interest = CalculateInterest();
            Deposit(interest);
        }

    }




    class W4
    {
        public static void Main()
        {
            Customer c1 = new Customer("Shamil", "Clementi", "G67347", new DateTime(1991, 03, 21));
            Customer c2 = new Customer("Raniah", "Clementi", "J76443", new DateTime(1993, 07, 09));
            Customer c3 = new Customer("Basim", "Clementi", "N47563", new DateTime(2006, 04, 25));


            SavingsAccount s = new SavingsAccount("G74798934", c1, 400000);
            s.Show();
            Console.WriteLine(s.CalculateInterest());
            s.CreditInterest();
            s.Show();

            CurrentAccount c = new CurrentAccount("7345-4353-33", c2, 3500);
            c.Show();
            Console.WriteLine(c.CalculateInterest());
            c.CreditInterest();
            c.Show();

            OverDraftAccount o = new OverDraftAccount("3434-34535-22", c3, -500);
            o.Show();
            Console.WriteLine(o.CalculateInterest());
            o.CreditInterest();
            o.Show();



            //this wont work here, because we are using "new" keyword and hence static binding is happening
            Account sa = new SavingsAccount("567-2543-316236", c2, 1200);
            sa.Show();
            Console.WriteLine(sa.CalculateInterest());
            sa.CreditInterest();
            sa.Show();





        }
    }
}
