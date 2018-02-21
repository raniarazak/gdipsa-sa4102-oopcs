using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class BankAccount
    {
        string AccNumber;
        string AccHolderName;
        double balance;

        //constructor
        public BankAccount(string accnumber, string holdername, double balance)
        {

            AccNumber = accnumber;
            AccHolderName = holdername;
            this.balance = balance;

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


        public string accNumber
        {
            get
            {
                return AccNumber;
            }

        }

        public string accHolder
        {
            get
            {
                return AccHolderName;
            }

            set
            {
                AccHolderName = value;
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

        public double Deposit(double amount)
        {
            balance = balance + amount;
            return balance;
        }

        public bool TransferTo(double amount, BankAccount AccountToTransfer)
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
    }

        public class W3_1
        {
            public static void Main()
            { 
          
            
            BankAccount a = new BankAccount("A64236t5482","Raniah", 500);
            BankAccount b = new BankAccount("B3652424634", "Shamil", 5000);

            a.Withdraw(50);
            b.Deposit(1000);

            Console.WriteLine(a.Balance);
            Console.WriteLine(b.Balance);

            a.TransferTo(100, b);

            Console.WriteLine(a.Balance);
            Console.WriteLine(b.Balance);

            a.TransferTo(350, b);
            Console.WriteLine(a.Balance);
            Console.WriteLine(b.Balance);

            a.Withdraw(50);
            Console.WriteLine(a.Balance);


        }
        }
}
