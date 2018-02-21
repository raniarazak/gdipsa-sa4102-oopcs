using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class BankAccountnew
    {
        string AccNumber;
        Customer AccHolderName;
        double balance;
       

        //constructor
        public BankAccountnew(string accnumber, Customer holdername, double balance)
        {

            AccNumber = accnumber;
            AccHolderName = holdername;
            this.balance = balance;

            holdername.AddAccount(this);


        }

        public BankAccountnew() : this("000-00000", new Customer(), 0)
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
            //    if (value > 0)
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

        public Customer accHolder
        {
            get
            {
                return AccHolderName;
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
            {
                Console.WriteLine("Not enough funds!");
                return false;
            }

        }

        public double Deposit(double amount)
        {
            balance = balance + amount;
            return balance;
        }

        public bool TransferTo(double amount, BankAccountnew AccountToTransfer)
        {
            if (Withdraw(amount))
            {
                AccountToTransfer.Deposit(amount);
                return true;

            }
            else
            {
                Console.WriteLine("Transfer not succesful!");
                return false;
            }
            
        }
     
        public string Show()
        {
            string n =String.Format("Account Number: {0}\nAccount Holder Details: \n{1}\nBalance: {2}\n"
                , AccNumber, AccHolderName.Show(), balance);
            return n;
        }
    }

     }
