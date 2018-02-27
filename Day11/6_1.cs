using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{

    abstract class Shape
    {

        public abstract double Area();

        public abstract double Perimeter();

        public int test()
        {
            Console.WriteLine("hello");
            return 0;
        }

    }

    class Rectangle: Shape
    {
        double length;
        double breadth;

        public Rectangle(double length,double breadth)
        {
            if (length > 0)
                this.length = length;
            else
                Console.WriteLine("Length cannot be negative");

            if(breadth > 0)
                this.breadth = breadth;
            else
                Console.WriteLine("Breadth cannot be negative");
        }

        

        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;

            }
        }

        public double Breadth
        {
            get
            {
                return breadth;
            }

            set
            {
                breadth = value;

            }
        }


        public override double Area()
        {
            return length * breadth;

        }

        public override double Perimeter()
        {
            return 2*(length + breadth);
        }
    }

    class Triangle :Shape
    {
        double side1;
        double side2;
        double side3;

        public Triangle(double side1,double side2, double side3)
        {
            if (side1 > 0 && side2 > 0 && side3 > 0)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }

            else Console.WriteLine("SIdes cannot be negative");
            
        }

        public double Side1
        {
            get
            {
                return side1;
            }

            set
            {
                side1 = value;

            }
        }

        public double Side2
        {
            get
            {
                return side2;
            }

            set
            {
                side2 = value;

            }
        }

        public double Side3
        {
            get
            {
                return side3;
            }

            set
            {
                side3 = value;

            }
        }

        public override double Area()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public override double Perimeter()
        {
            return side1+side2+side3;
        }


    }

    class W6_1
    {
        public static void Main()
        {
            Triangle t1 = new Triangle(1,-9,-2);
            Rectangle r1 = new Rectangle(-3, 0);
            r1.test();
            Console.WriteLine(t1.Area());
            Console.WriteLine(r1.Area());

            Console.WriteLine(t1.Perimeter());
            Console.WriteLine(r1.Perimeter());

        }
    }


}
