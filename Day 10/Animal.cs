using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    class Animal
    {
        public void p()
        {

        }
    }

    class Cat : Animal
    {
        public void q()
        {

        }
    }

    class Test
    {
        public static void Main()
        {
            Animal v = new Animal();
            Cat w = new Cat();
            Animal v2 = w; // this assignmnet here is allowable because cat is also an animal
                           //cat has the charecteristic of its parent animal

            //Cat w2 = v2;//we cannot assign an animal variable to cat
            // even though we are assigning cat w to animal v2, we cannot assign animal v2 to cat w2
            //although both v2 and w2 are assigned to a cat object at this moment, the compiler does not 
            //understand this, it takes each line at a time and hence it thinks we are assigning an animal
            //object to cat

            //v2.q();// we cannot do this even though we assigned a cat object to animal v2 because we are
                  // accessing v2 through the animal qualities i.e 
                  //C# sees it as an animal and hence cannot

            Cat w3 = (Cat)v2;// here we are saying we want to treat animal v2 as a Cat object, 
            //                 //so we can assign it to Cat object
            w3.q();// here its possible to call a method of Cat object as w2 is now Cat


        }
    }

}
