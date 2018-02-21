using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_OO
{
    public class Triangle
    {
        double bottom;
        double height;

        //constructor
        public Triangle(double b, double h)
        {
            this.bottom = b;
            this.height = h;

        }

        //property
        public double Bottom
            {
            get
            {

                return bottom;
            }

            set
            {
                bottom = value;

            }
            }

        public double Height
        {
            get
            {

                return height;
            }

            set
            {
                height = value;

            }
        }


        //methods
        public double Calculate_Area()
        {
            double Area = 0.5 * bottom* height;
            return Area;

        }

        public double Calculate_perimeter()
        {
            double Perimeter = 2 * (bottom + height);
            return Perimeter;
        }


     }

    public class W2_2
    {
        
        static void Main()
        {
            Triangle r = new Triangle(2,5);

            double area= r.Calculate_Area();

            Console.WriteLine("Area {0}",area);

            double perimeter = r.Calculate_perimeter();

            Console.WriteLine("Perimeter {0}",perimeter);

            r.Bottom = 10;


            area = r.Calculate_Area();

            Console.WriteLine("Area {0}", area);

            perimeter = r.Calculate_perimeter();

            Console.WriteLine("Perimeter {0}", perimeter);






        }

    }
}
