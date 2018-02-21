using System;
using System.Collections;

namespace Day_10
{
    class A
    {
        private int x;
        protected int y;
    }

    class B : A
    {
        //public void p(){
        //    x=1;
        //    y=4;
        //    }
    }
    class Program
    {
        static int[] w(int size)
        {
            int[] m = new int[size];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = i * 2;
            }
            return m;
        }


        static int[] GrowDouble(int[] existing)//to grow an array to double it previous size,
             //we have to create a new array with bigger size and then copy values of older array
             //into new. this is very tedious. C# provides ArrayList for this purpose. it works like an 
             //array, but it will automatically adjust the size of the array to what is required.
             //no need to create a new array
        {
            int[] m = new int[existing.Length * 2];
            for(int i = 0; i <existing.Length; i++)
            {
                m[i] = existing[i];
            }
            return m;
        }

        //ArrayList example, it uses system.collections,we can use array list when we do not know the
        //size of our array.

        static ArrayList v(int size)
        {
            ArrayList b = new ArrayList();//declaring an ArrayList and creating an array list
            for (int i = 0; i < size; i++)
            {
                b.Add(i * 2); // can add elements this way also,Add is a method in  ArrayList
            }

            for (int i = 0; i <b.Count; i++)// we use b.Count instead of b.Length
                                            //count specifies the num of elemnts presently in the array
            {
                Console.WriteLine(b[i]); 
            }

            return b;




        }





        static void Main(string[] args)
        {
            int[] z = w(10);
            for(int i = 0; i < z.Length; i++)
            {
                Console.WriteLine(z[i]);
            }
        }
    }
}
