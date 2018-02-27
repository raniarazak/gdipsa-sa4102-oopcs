using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class BadTriangleException: ApplicationException
    {
        public BadTriangleException() : base() { }
        public BadTriangleException(string g) : base(g) { }
    }
    class Triangle
    {
        double a;
        double b;
        double c;

        public Triangle(double a, double b, double c)
        { 
            if ((a < 0) || (b < 0) || (c < 0))
            {
                throw new BadTriangleException("All should be greater than 0");
            }
            if (a + b <= c || b + c <= a || c + a <= b)
            {
                throw new BadTriangleException("sum of 2 sides should be greater than the third side");

            }
            
                this.a = a;
                this.b = b;
                this.c = c;

        }

        public double Area()
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return (area);
        }

        public double Perimeter()
        {
            double p = a + b + c;
            return p;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Triangle t = new Triangle(0, 1, 2);
                Console.WriteLine(t.Area());
                Console.WriteLine(t.Perimeter());
            }
            catch(BadTriangleException b)
            {

                Console.WriteLine("You cannot create the triangle:" + b.Message);
            }

        }

    }
}
