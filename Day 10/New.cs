using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    
    class New
    {
        static void Main()
        {
            Animal v = new Animal();
            Cat w = new Cat();
            Animal v2 = w; // this assignmnet here is allowable because cat is also an animal
                           //cat has the charecteristic of its parent animal

            v.p();
            w.p();
            v2.p();
            //v2.q();//cannot do this as v2 seen as animal

            //Cat w3 = v2;//cannot do as v2 is animal..cannot give into cat
            Cat w2 = (Cat)v2; // casting animal object into a cat object
            w2.q(); //now we can call method q using w2;
        }
        
    }
       
}
