using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class Grandfather
    {
        protected int x;
        protected int y=1;
        public Grandfather()
        {
            this.x = 10;
        }

        public virtual void Px()
        {
            Console.WriteLine("grandfather");
            Console.WriteLine(x);
            Console.WriteLine(this.y);
        }
    }

    class Father: Grandfather
    {
        //protected int x;
        protected int y = 2;
        public Father():base()
        {
            //this.x = 20;
        }

        //public new void Px()
        //{
        //    Console.WriteLine("father");
        //    Console.WriteLine(x);
        //    Console.WriteLine(y);
        //}
    }

    class Son: Father
    {
        //protected int x;
        protected int y=3;

        public Son(): base()
        {
        }
        //public new void Px()
        //{
        //    Console.WriteLine("son");
        //    Console.WriteLine(x);
        //    Console.WriteLine(y);
        //}

    }

    class RunTest
    {
        public static void Main()
        {
            Son son = new Son();
            son.Px();

            //Father father = new Father();
            //father.Px();

            //father = son;
            //son.Px();
            //father.Px();

        }

    }
}
