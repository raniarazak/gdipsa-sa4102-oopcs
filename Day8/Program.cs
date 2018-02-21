using System;
using LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Product
    {
        //class A // we can have a class inside a class called nested class
        //    //this is made when an instance this class cannot exist without the class Product
        //{

        //}

        //attributes
        string name;
        string id;
        int quantity;

        //constructors : do not have a return type, and is declared as public
        public Product(string n, string i, int q)
        {
            name = n;
            id = i;
            //if (q > 0) : no need for this coz validation happening in properties otherwise must do here
                Quantity = q;
        }

        //public Product(string n, string i)
        //{
        //    name = n;
        //    id = i;
        //    Quantity = 1;
        //}
         //can declare the above method like below also
        public Product(string name, string id):this(name, id, 0)//this means take arguments of this constructor(with 2 args) 
                                                                //& call basic constructor(with 3 args)
        {
            //no need to give code here as we are using constructr initializer 
            // and can just give these value into the Product constructor that has 3 arguments
        }

        public Product() //default values constructor
        {
            name = "Table";
            id = "1432P";
            //if (q > 0) : no need for this coz validation happening in properties otherwise must do here
            Quantity = 10;
        }



        //properties: can hae properties with just a get and no set
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if(value >= 0)
                    quantity = value;
            }
        }

        public string Id //this property has only getter
        {
            get
            {
                return id;
            }
        }

        public string Name // this property has only getter
        {
            get
            {
                return name;
            }
        }



        //methods

        public void Restock(int q)
        {
            Quantity = Quantity + q; // Caps 'Q' Quantity calls the property and using small 'q' quantity
                                    //calls the attribute
        }

        public void Rename(string s)
        {
            name = s;
        }

        public string Show()
        {
            return String.Format("Product:{0},{1},{2}", Name, Id, Quantity);
            //this one returns the string when COnsole.WriteLine prints out
        }

        //public Customer DoSomething()
        //{
        //    return new Customer("", "");
        //    //This can be used during team projects, can create dummy classes so 
        //    //other team member can continue with his work using this method

        //}
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product("Table","P10001",20);
            Product b = new Product("Chair", "P10002");
            Product c = new Product();
            //Console.WriteLine(a); //can give object inside a Console.WriteLine

            Console.WriteLine(a.Show());
            b.Restock(12);
            b.Rename("Table Light");
            Console.WriteLine(b.Show());
        }
    }
}
