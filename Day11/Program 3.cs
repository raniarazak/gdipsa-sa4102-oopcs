using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    class Customer : IComparable
    {
        string name;
        int creditlimit;
        public Customer(string name, int creditlimit)
        {
            this.name = name;
            this.creditlimit = creditlimit;
        }

        //public int CompareTo(object o)
        //{
        //    Customer c = (Customer)o;
        //    return this.creditlimit.CompareTo(c.creditlimit);

        //}

        public int CompareTo(object o)
        {
            Customer c = (Customer) o;
            return this.name.CompareTo(c.name);

        }

        public override string ToString()
        {
            return String.Format("[Customer:{0},{1}]", name, creditlimit);
        }

    }
    class Program_3
    {
        static void Sort(IComparable[] objects)//sort is operating on an array of icomparables
        {
            IComparable item1 = (IComparable)objects[0];
            IComparable item2 = (IComparable)objects[1];
            item1.CompareTo(item2);
            //it is only seeing the icomparable aspect of this
            //interface is also a type, it needs to be casted to a type and from there it can use
            //CompareTo

        }
        static void Main()
        {
            int[] numbers = new int[] { 5, 2, 19, 8 };

            Customer[] customers = new Customer[] { new Customer("Raniah", 10000), new Customer("Shamil", 50000), new Customer("Basim", 2500) };

            //Array.Sort(numbers);
            Array.Sort(customers);

            foreach(Customer c in customers)
            {
                Console.WriteLine(c);
            }

            //for(int i = 0; i < customers.Length; i++)
            //{
            //    Console.WriteLine(customers[i]);
            //}


        }

    }

 
}

