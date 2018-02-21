using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    public class Customer
    {
        string name;
        string address;
        string pass_num;
        DateTime dob;


        //constructor
        public Customer(string name, string address, string pass_num)//give lesser num of args as base and then declare differnet
                                                                     //versions of the same construtor
        {
            this.name = name;
            this.address = address;
            this.pass_num = pass_num;
            //this.dob = dob;
        }

        public Customer(string name, string address, string pass_num, DateTime dob) : this(name, address, pass_num)

        {
            this.dob = dob;
        }


        public Customer(string name, string address, string pass_num, int age) : this(name, address, pass_num)
        {
            this.dob = new DateTime(DateTime.Now.Year - age, 1, 1);
        }


        public Customer() : this("No Name", "NO ADDRESS", "XXX_XXX", new DateTime())
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


        //method

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
}
