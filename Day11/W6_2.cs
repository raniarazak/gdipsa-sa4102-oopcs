using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    interface Iinvestment
    {
        string Description
        {
            get;
        }

        double Cost
        {
            get;
        }

        DateTime Acquired
        {
            get;
        }

        double EstimatedValue
        {
            get;
        }

        double Profit();
        
    }

    class Coin : Iinvestment
    {
        string desc;
        double cost;
        double estimatedvalue;
        DateTime acquired;

        public Coin(string desc, double cost, double estimatedvalue, DateTime acquired)
        {
            this.desc = desc;
            this.cost = cost;
            this.estimatedvalue = estimatedvalue;
            this.acquired = acquired;
        }
        public string Description
        {
            get { return desc; }
                
        }

        public double Cost
        {
            get { return cost; }
        }

        public DateTime Acquired
        {
            get { return acquired; }
        }

        public double EstimatedValue
        {
            get { return estimatedvalue; }
        }

        public double Profit()
        {
            return estimatedvalue - cost;
        }

    }


    class Antique : Iinvestment
    {
        string desc;
        double cost;
        double estimatedvalue;
        DateTime acquired;


        public Antique(string desc, double cost, double estimatedvalue, DateTime acquired)
        {
            this.desc = desc;
            this.cost = cost;
            this.estimatedvalue = estimatedvalue;
            this.acquired = acquired;
        }
        public string Description
        {
            get { return desc; }

        }

        public double Cost
        {
            get { return cost; }
        }

        public DateTime Acquired
        {
            get { return acquired; }
        }

        public double EstimatedValue
        {
            get { return estimatedvalue; }
        }

        public double Profit()
        {
            return estimatedvalue - cost;
        }

    }



    class W6_2
    {
        static void Main()
        {
            List<Iinvestment> list = new List<Iinvestment>();
            Coin inv1 = new Coin("India Coin",2000,10000,new DateTime(2017,09,07));
            Antique inv2 = new Antique("Gold ring", 5000, 100000, new DateTime(1989, 03, 05));

            list.Add(inv1);
            list.Add(inv2);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0}: {1}  ,  {2}", list[i].Description, list[i].Profit(), DateTime.Now.Year - list[i].Acquired.Year);
            }
            
        }
    }
}
