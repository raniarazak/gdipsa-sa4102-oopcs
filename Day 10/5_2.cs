using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    public class BankBranch
    {
        private string branchName;
        private string branchManager;
        private List<Account> bankAccounts;

        public BankBranch(string branchName, string branchManager, List<Account> bankAccounts)
        {
            this.branchName = branchName;
            this.branchManager = branchManager;
            this.bankAccounts = bankAccounts;

        }

        public BankBranch() : this("", "", new List<Account>()) { }

        public string BName
        {
            get
            {
                return branchName;
            }
            set
            {
                branchName = value;

            }

        }

        public string BManager
        {
            get
            {
                return branchManager;
            }
            set
            {
                branchManager = value;

            }

        }

        public List<Account> BAccounts
        {
            get
            {
                return bankAccounts;
            }
            set
            {
                bankAccounts = value;

            }

        }

        public void AddAccount(Account acc)
        {
            bankAccounts.Add(acc);
        }

        public void PrintCustomers()
        {
            for(int i = 0; i < bankAccounts.Count; i++)
            {
                Console.WriteLine(bankAccounts[i].AccHolderName.Name);
            }

        }

        public double TotalDeposits()
        {
            double total=0;
            for(int i = 0; i < bankAccounts.Count; i++)
            {
                total = total + bankAccounts[i].Balance;
                
            }
            return total;
        }


        public double TotalInterestPaid()
        {
            double totalInterestPay = 0;
            for (int i= 0;i<bankAccounts.Count; i++)
            {
                if (bankAccounts[i].Balance >= 0)
                {
                    totalInterestPay = totalInterestPay + bankAccounts[i].CalculateInterest();
                }

            }
            Console.WriteLine("Total interest to pay is {0:C}", totalInterestPay);
            return totalInterestPay;

        }

        public double TotalInterestEarned()
        {
            double totalInterestEarned = 0;
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                if (bankAccounts[i].Balance < 0)
                {
                    totalInterestEarned = totalInterestEarned + bankAccounts[i].CalculateInterest();
                }

            }

            Console.WriteLine("Total interest to receive is {0:C}", totalInterestEarned);
            return -totalInterestEarned;

        }






    }
    public class _5_2
    {
        public static void Main()
        {
            

            Customer c1 = new Customer("Shamil", "Clementi", "G67347", new DateTime(1991, 03, 21));
            Customer c2 = new Customer("Basim", "Clementi", "J76443", new DateTime(1993, 07, 09));
            Customer c3 = new Customer("Raniah", "Clementi", "N47563", new DateTime(2006, 04, 25));
            Customer c4 = new Customer("Ramla", "CLementi", "B64367", new DateTime(1966, 09, 01));
            Customer c5 = new Customer("Abdul Razak", "CLementi", "H54567", new DateTime(1956, 11, 01));


            SavingsAccount sc1 = new SavingsAccount("G74798934", c1, 4000);
            CurrentAccount cc2 = new CurrentAccount("7345-4353-33", c2, 3500);
            OverDraftAccount oc3 = new OverDraftAccount("3434-34535-22", c3, -500);
            OverDraftAccount oc4 = new OverDraftAccount("342-24525-245", c4, -1000);
            OverDraftAccount oc5 = new OverDraftAccount("3543-2352-5-253", c5, 6700);

            List<Account> banklist = new List<Account>();

            BankBranch bb = new BankBranch("Clementi", "Mr. John", banklist);



            bb.AddAccount(sc1);
            bb.AddAccount(cc2);
            bb.AddAccount(oc3);
            bb.AddAccount(oc4);
            bb.AddAccount(oc5);

            //Console.WriteLine(sc1.CalculateInterest());
            //Console.WriteLine(cc2.CalculateInterest());
            //Console.WriteLine(oc3.CalculateInterest());
            //Console.WriteLine(oc4.CalculateInterest());
            //Console.WriteLine(oc5.CalculateInterest());


            //Console.WriteLine(bb.TotalDeposits());
            bb.TotalInterestPaid();
            bb.TotalInterestEarned();

            bb.BAccounts[3].Withdraw(40);
            Console.WriteLine(bb.BAccounts[3].Balance);





            bb.PrintCustomers();






        }
    }
}
