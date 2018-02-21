using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_OO
{
    class Rectangle
    {
        //attributes
        int length;
        int breadth;

        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }
        // properties
        public int Length
        {
            get
            {
                return Length;
            }
            set
            {
                length = value;
            }

        }
        
        public int Area// property; it is like a computed attribute
        {
            get
            {
                return length * breadth;
            }
        }

        //methods
        public int GetArea()
        {
            return length * breadth;
        }
    }
}
