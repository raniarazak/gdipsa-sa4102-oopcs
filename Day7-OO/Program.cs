using System;
using ISS.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day7_OO
{
    class Coin // can create class by adding class(visual studio) and just specify it as public
    {
        int face;

        public void Flip()
        {
            face = MyMath.RNDInt(2);
        }

        public int GetFace()
        {
            return face;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //using accessor and mutator methods
            Person p1 = new Person();
            p1.SetAge(10);
            Console.WriteLine(p1.GetAge());

            //using property
            Person p2 = new Person();
            p2.Age = 34;//this is the set part
            Console.WriteLine(p2.Age); //this one is the accessor, get part

            Person p3 = new Person("Raniah", 23);
            Console.WriteLine();

            Coin c1;
            c1 = new Coin();
            for (int i = 0; i < 10; i++)
            {
                c1.Flip();
                Console.WriteLine(c1.GetFace());
            }

            Coin c2;
            c2 = new Coin();
        }
    }
}
