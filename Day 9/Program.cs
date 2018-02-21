using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class Order
    {
        Product[] items = new Product[10];
        int count;

        public Order(int n)
        {
            count = 0;
            items = new Product[10];
        }
        public void Add(Product p)
        {
            items[count] = p;
            count = count + 1;
        }

        public double TotalPrice()
        {
            double total = 0;
            for (int i = 0; i < count; i++)
            {
                total = total + items[i].Price;
            }
            return total;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i].Show());
            }
        }
    }




    class Customer
    {
        string name;
        Order order;
        static int numberofCustomers;

        public Customer(string name)
        {
            this.name = name;
            order = new Order(8);
            numberofCustomers = numberofCustomers + 1;
        }

        public void Buy(Product p)
        {
            order.Add(p);
        }

        public void PrintOrders()
        {
            order.Print();
        }

        public double CostOfPurchase()
        {
            return order.TotalPrice();
        }

    }





    class Product
    {
        string id;
        string name;
        double price;

        public Product(string id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;

        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public string Show()
        {
            return String.Format("Product[{0},{1},{2}]", id, name, price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            //Product c; 
            //if we declare like this, this means it doesnt refer
            //to any object, has null value


            //string v = "abc";
            //string w=null;
            //null means it is not referring to an obj
            //it is different to an empty string
            //Console.WriteLine(w.ToUpper());

            //Console.WriteLine(a.Price);
            //gives 0,default constructor(DC) gives it this value


            //Console.WriteLine(a.Name);//(DC) gives empty string value

            //Console.WriteLine(a.Show());
            //Console.WriteLine(b.Show());

            /*Order order = new Order(8);*///calling the constructor with n=8 to create an
                                           //items list/array.

            Customer c = new Customer("Raniah");
            Product a = new Product("P1001", "Laptop", 2500);
            Product b = new Product("P1002", "Tablet", 1000);
            Product d = new Product("P1003", "Mobile", 700);

            c.Buy(a);
            c.Buy(b);
            c.Buy(d);

            c.PrintOrders();

            Console.WriteLine(c.CostOfPurchase());
            Console.WriteLine(c.GetType());
            Console.WriteLine("abc".GetType());




        }
    }
}
