using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
   

       public class AccountS
        {
            // Attributes
            private string accountNumber;
            private CustomerS accountHolder;
            protected double balance;

            // Constructor
            public AccountS(string number, CustomerS holder, double bal)
            {
                accountNumber = number;
                accountHolder = holder;
                balance = bal;
            }

            public AccountS()
                : this("000-000-000", new CustomerS(), 0)
            {
            }

            // Properties
            public string AccountNumber
            {
                get
                {
                    return accountNumber;
                }
            }
            public CustomerS AccountHolder
            {
                get
                {
                    return accountHolder;
                }
                set
                {
                    accountHolder = value;
                }
            }
            public double Balance
            {
                get
                {
                    return balance;
                }
                protected set
                {
                    balance = value;
                }
            }

            // Methods

            public void Deposit(double amount)
            {
                balance = balance + amount;
            }

            public bool Withdraw(double amount)
            {
                if (amount < Balance)
                {
                    balance = balance - amount;
                    return (true);
                }
                else
                {
                    Console.WriteLine("Cannot withdraw");
                    return (false);
                }
            }

            public void TransferTo(double amount, AccountS another)
            {
                if (Withdraw(amount))
                    another.Deposit(amount);
            }

            public double CalculateInterest()
            {
                return (Balance * 1 / 100);
            }

            public void CreditInterest()
            {
                Deposit(CalculateInterest());
            }

            public string Show()
            {
                string m = String.Format
                             ("[BankAccount:accountNumber={0},accountHolder={1},balance={2}]",
                              AccountNumber, AccountHolder.Show(), Balance);
                return (m);
            }
        }

        public class CurrentAccountS : AccountS
        {

            public CurrentAccountS(string number, CustomerS holder, double bal)
                : base(number, holder, bal)
            {
            }

            public new double CalculateInterest()
            {
                return (Balance * 0.25 / 100);
            }

            public new string Show()
            {
                string m = String.Format
                             ("[CurrentAccount:accountNumber={0},accountHolder={1},balance={2}]",
                              AccountNumber, AccountHolder.Show(), Balance);
                return (m);
            }
        }

        public class OverdraftAccountS : AccountS
        {
            private static double interestRate = 0.25;
            private static double overdraftInterest = 6;

            public OverdraftAccountS(string number, CustomerS holder, double bal)
                : base(number, holder, bal)
            {
            }

            public new bool Withdraw(double amount)
            {
                balance = balance - amount;
                return (true);
            }

            public new double CalculateInterest()
            {
                return ((Balance > 0) ?
                        (Balance * interestRate / 100) :
                        (Balance * overdraftInterest / 100));
            }

            public new string Show()
            {
                string m = String.Format
                             ("[OverdraftAccountS:accountNumber={0},accountHolder={1},balance={2}]",
                              AccountNumber, AccountHolder.Show(), Balance);
                return (m);
            }
        }

        public class CustomerS
        {
            //
            // Attributes
            //

            private string name;
            private string address;
            private string passport;
            private DateTime dateOfBirth;

            //
            // Constructor
            //

            public CustomerS(string name, string address, string passport, DateTime dob)
                : this(name, address, passport)
            {
                this.dateOfBirth = dob;
            }

            public CustomerS(string name, string address, string passport, int age)
                : this(name, address, passport)
            {
                this.dateOfBirth = new DateTime(DateTime.Now.Year - age, 1, 1);
            }

            public CustomerS(string name, string address, string passport)
            {
                this.name = name;
                this.address = address;
                this.passport = passport;
            }

            public CustomerS()
                : this("ThisName", "ThisAddress", "ThisPassport", new DateTime(1980, 1, 1))
            {
            }

            //
            // Properties
            //

            public string Name
            {
                get
                {
                    return name;
                }
            }

            public string Address
            {
                get
                {
                    return address;
                }
                set
                {
                    address = value;
                }
            }

            public string Passport
            {
                get
                {
                    return passport;
                }
                set
                {
                    passport = value;
                }
            }

            public int Age
            {
                get
                {
                    return DateTime.Now.Year - dateOfBirth.Year;
                }
            }

            // Methods

            public string Show()
            {
                string m = String.Format
                     ("[Customer:name={0},address={1},passport={2},age={3}]",
                              Name, Address, Passport, Age);
                return (m);
            }

        }


      
    class SirSolution
    {
        public static void Main()
        {
            CustomerS cus1 = new CustomerS("Tan Ah Kow", "2 Rich Street",
                                      "P123123", 20);
            CustomerS cus2 = new CustomerS("Kim May Mee", "89 Gold Road",
                                      "P334412", 60);

            AccountS a1 = new AccountS("S0000223", cus1, 2000);
            //Console.WriteLine(a1.CalculateInterest());
            OverdraftAccountS a2 = new OverdraftAccountS("O1230124", cus1, 2000);
            //Console.WriteLine(a2.CalculateInterest());
            CurrentAccountS a3 = new CurrentAccountS("C1230125", cus2, 2000);
            //Console.WriteLine(a3.CalculateInterest());

            //AccountS a4 = new CurrentAccountS("F7467228", cus2, 2000);
            //Console.WriteLine(a4.CalculateInterest());


            Console.WriteLine(a2.Show());
            Console.WriteLine(a2.CalculateInterest());
            a2.CreditInterest();
            Console.WriteLine(a2.Show());

        }
    }
}
