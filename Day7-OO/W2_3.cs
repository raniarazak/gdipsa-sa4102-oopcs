using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.LIB;

namespace Day7_OO
{
    public class Die
    {
        private int faceUp;

        public Die()
        {
            Throw();
        }
        // Methods
        private int GetFaceUp()
        {
            return faceUp;
        }
        public int Throw()
        {
            this.faceUp = MyMath.RNDInt(6) + 1;
            return this.faceUp;
        }
        public string StrFaceUp
        {
            get
            {
                switch (GetFaceUp())
                {
                    case 1: return "1";
                    case 2: return "2";
                    case 3: return "3";
                    case 4: return "4";
                    case 5: return "5";
                    case 6: return "6";
                    default: return "??";
                   
                }
            }
        }
    }
    class W2_3
    {
        public static void Test8()
        {
            Die die = new Die();
            int eight = 0;
            int total = 1000000
                ;
            for (int i = 0; i < total; i++)
            {
                if (die.Throw() + die.Throw() == 8)
                    eight++;
            }
            Console.WriteLine("Occurrence of 8 is {0}", ((double)eight) / total);
        }
        public static void Test(int n)
        {
            Die die = new Die();
            int occurs = 0;
            int total = 1000000;
            for (int i = 0; i < total; i++)
            {
                if (die.Throw() + die.Throw() == n)
                    occurs++;
            }
            Console.WriteLine("Occurrence of {0} is {1}", n, ((double)occurs) / total);
        }

        public static void Probability8()
        {
            int occurs = 0;
            for (int i = 1; i <= 6; i++)
                for (int j = 1; j <= 6; j++)
                    if (i + j == 8)
                        occurs = occurs + 1;
            Console.WriteLine("Probability of 8 is {0}", ((double)occurs) / 36);
        }

        public static void Probability(int n)
        {
            int occurs = 0;
            for (int i = 1; i <= 6; i++)
                for (int j = 1; j <= 6; j++)
                    if (i + j == n)
                        occurs = occurs + 1;
            Console.WriteLine("Probability of {0} is {1}", n, ((double)occurs) / 36);
        }

        public static void Main()
        {
            Test8();
            Probability8();
            // (2,6) (3,5) (4,4) (5,3) (6,2) / 6x6
            Test(9);
            Probability(9);
        }
    }
}

