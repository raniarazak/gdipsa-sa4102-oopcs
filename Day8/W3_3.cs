using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class W3_3
    {
        static void Main() 
        {
            Rational a = new Rational(3, 4);
            Rational b = new Rational(4, 5);

            Rational c = a.Add(b);

            Console.WriteLine(c.StrVal());

            c = a.Subtract(b);

            Console.WriteLine(c.StrVal());



        }
    }
}
