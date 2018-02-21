using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    class CustomerM
    {
        string name;
        string address;

        public CustomerM (string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public override string ToString() // the ToString method is a C# existing method, but it
        //                                   is declared as virtual, so we can override that 
        //                                  ToString() method to change it to what we want.
        {
            return String.Format("[Customer: {0} , {1}]",name,address);
        }

        public void Show()
        {
            Console.WriteLine("Name: {0}, Address:{1}", name, address);
        }
    }
    class Customer_Main
    {
        static void Main()
        {
            CustomerM c = new CustomerM("Raniah", "Clementi");
            c.Show(); // this just writes the name of the class and namespace
                      //Console.WriteLine can receive a object

            Console.WriteLine();
            //Console.WriteLine();



        }
    }
}
