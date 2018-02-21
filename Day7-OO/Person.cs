using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_OO
{
    class Person
    {
        //attributes
        string name;
        int age;

        //3 overloaded constructors are given below
        public Person()
        {
            age = 1;
            name = "";
        }

        public Person(string n)
        {
            age = 1;
            name = n;
        }

        public Person(string n, int a)
        {
            age = a;
            name = n;
        }



        //accessor methods
        public int GetAge()
        {
            return age;
        }

        //mutator methods perform validation to check if the value entered is acceptable
        public void SetAge(int newvalue)
        {
            newvalue = newvalue * 365;
            if (newvalue > 0)
            {
                age = newvalue;
            }

            else
            {
                Console.WriteLine("invalid age");
            }
        }

        // THis is a property which has a get part and a set part. this is diff from attributr age
        public int Age
        {
            get
            {
                return age / 365;
            }
            set
            {
                int newvalue = value * 365;
                if (newvalue > 0)
                    age = newvalue;
                else
                    Console.WriteLine("invalid age");
            }

        }
    }
}
