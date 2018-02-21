using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10
{
    class Shape
    {
        int x;
        int y;
        public virtual void Draw()
        {
            Console.WriteLine("Draw of Shape");
        }

    }
    class Circle : Shape
    {
        public override void Draw()
        {
            // draw circle
            Console.WriteLine("Draw of Circle");
        }
    }
    class Square : Shape
    {
        public override void Draw()
        {
            // draw square
            Console.WriteLine("Draw of Shape Square");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            // draw triangle
            Console.WriteLine("Draw of Triangle");
        }
    }

    class Drawing
    {
        //ArrayList allshapes = new ArrayList();
        List<Shape> allshapes = new List<Shape>();//Only SHape objects can be accomodated in this list
        List<int> l2 = new List<int>();
        public void Add(Shape s)
        {
            allshapes.Add(s);
            l2.Add(3);
        }
        public void Draw()
        {
            for (int i = 0; i < allshapes.Count; i++)
            {
               // Shape s = (Shape)allshapes[i];  //SO if we are using List, we dont need to cast (Shape)
                allshapes[i].Draw();
            }
        }
    }


    class Shape_Main
    {
        public static void Main()
        {
            Drawing d = new Drawing();
            d.Add(new Triangle());
            d.Add(new Square());
            d.Add(new Circle());
            d.Add(new Circle());
            d.Add(new Square());
            d.Add(new Triangle());

            d.Draw();
        }
    }
}
