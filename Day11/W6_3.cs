using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    class W6_3
    {
        class Customer : IComparable
        {
            string name;
            string address;
            double balance;

            public Customer(string name, string address,double balance)//give lesser num of args as base and then declare differnet
                                                                         //versions of the same construtor
            {
                this.name = name;
                this.address = address;
                this.balance = balance;
                //this.dob = dob;
            }

            public string Name
            {
                get
                {
                    return name;
                }
            }

            public double Balance
            {
                get
                {
                    return balance;
                }
                set
                {
                    balance = value;

                }

            }

            public int CompareTo(object o)
            {
                if (o is Customer)
                { 
                    Customer c = (Customer)o;
                    return balance.CompareTo(c.Balance);
                }
                    
                return -1;
            }

            public static bool operator <(Customer a, Customer b)
            {
                return (a.CompareTo(b) < 0);
            }

            public static bool operator >(Customer a, Customer b)
            {
                return (a.CompareTo(b) > 0);
            }


        }
        static void Main()
        {
            Customer c = new Customer("Tan Ah Kow", "4 Short Street", 2000);
            Customer d = new Customer("Tan Ah Lian", "81 Berry Road", 1500);
            Console.WriteLine(c.CompareTo(d));
            Console.WriteLine(c > d);

        }
    }
}
