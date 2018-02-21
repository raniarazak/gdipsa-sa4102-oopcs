using System;
using LIB; //this is our library
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB
{
    public class Customer
    {
        string name;
        string address;

        public Customer(string n, string a)
        {
            name = n;
            address = a;

        }

        public void Print()
        {
            Console.WriteLine("{0}/{1}", name, address);
        }
    }
}
