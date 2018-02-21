using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Customer
    {
        string name;
        string address;
        string pass_num;
        DateTime dob;
        BankAccountnew[] accounts;
        int numOfAccounts;


        //constructor
        public Customer(string name,string address,string pass_num)//give lesser num of args as base and then declare differnet
                                                            //versions of the same construtor
        {
            this.name = name;
            this.address = address;
            this.pass_num = pass_num;
            this.accounts = new BankAccountnew[10];
            numOfAccounts = 0;
            //this.dob = dob;
        }

        public Customer(string name, string address, string pass_num, DateTime dob):this(name,address,pass_num)

        {
            this.dob = dob;
        }


        public Customer(string name, string address, string pass_num, int age):this(name,address,pass_num)
        {
            this.dob=new DateTime(DateTime.Now.Year-age,1,1);
        }


        public Customer() : this("No Name","NO ADDRESS","XXX_XXX",new DateTime())
        {

        }

        //property

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


        public string Pass_num
        {
            get
            {
                return pass_num;
            }
            set
            {
                pass_num = value;

            }

        }

        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;

            }

        }

        public BankAccountnew[] Accounts
        {
            get
            {
                return accounts;
            }
        }

        public int NumOfAccounts
        {
            get
            {
                return numOfAccounts;
            }
        }

        //method
        public void AddAccount(BankAccountnew a)
        {
            accounts[numOfAccounts] = a;
            numOfAccounts++;
        }

        public int GetAge()
        { 
            int age = DateTime.Now.Year - dob.Year;
            return age;

        }

        public string Show()
        {
            string m = String.Format("Name: {0}\tAddress: {1}\tPassport Num: {2}\tDate Of Birth: {3:d}", 
                name, address, pass_num, dob);
            return m;
        }

    }


    class W3_2
    {

        public static void Main()
        {
            Customer c1 = new Customer("Raniah", "39 Prince Georges Park,12-30", "D23467",new DateTime(1993, 07, 09));
            Customer c2 = new Customer("Shamil", "113 Clementi St 13,02-37", "V73662",new DateTime(1991, 03, 21));

            BankAccountnew b1 = new BankAccountnew("F32642345", c1, 12000);
            BankAccountnew b2 = new BankAccountnew("A34567345", c2, 40000);

            BankAccountnew b3 = new BankAccountnew("D72157632", c1, 4000);

            //Console.WriteLine(b1.Show());
            //Console.WriteLine(b2.Show());

            ////b1.Deposit(1000);
            ////Console.WriteLine(b1.Show());

            //b1.Withdraw(14000);
            //b1.TransferTo(14000, b2);
            

            //Customer c3 = new Customer("Basim", "SAUDI ARABIA", "f53333", 12);
            //Console.WriteLine(c3.Show());


            //Customer c4 = new Customer("FATIMA", "SAUDI ARABIA AS_SAFA", "N63333", new DateTime(1995,11,25));

            BankAccountnew[] am = c1.Accounts;

            for (int i = 0; i < c1.NumOfAccounts; i++)
            {
                
                Console.WriteLine(am[i].Show());

            }



            







            //c1.Address = "Blaaaaaaaaaaa";//setting

            //Console.WriteLine("{0:D} ,{1}  , {2}, {3}", c2.DOB, c2.GetAge(), c1.GetAge(), c1.Address);

        }
    }
}
