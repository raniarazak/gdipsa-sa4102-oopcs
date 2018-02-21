using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    class A
    {
        protected int x;
        public A(int x) { this.x = x; }

        public void P()// COnvention says if we have a public entity we start name with CAPS
        {
            Console.WriteLine("P of A [{0}]", x);
        }
        public void Q()
        {
            this.x = this.x + 10;
            this.P();          
        }

    }


    class B : A
    {
        public B(int x) : base(x) { }

        public new void P()
        {
            Console.WriteLine("P of B [{0}]", x);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            A x = new A(8);
            //x.Q();//gives 18

            B y = new B(9);
            //y.Q();// gives 19 when B class didnt have a new function P()

            x.P();//gives 8
            y.P();//gives 9

            x.Q();//gives 18, calls P of A
            y.Q();//gives 19, calls P of A; because when it goes into A for executing Q, it assumes
                   // y is of A class and executes P() of A class and not P() of Class B although y is an 
                   //instance of class B. TO overcome this anomaly, we use virtual/override
        }
    }
}
