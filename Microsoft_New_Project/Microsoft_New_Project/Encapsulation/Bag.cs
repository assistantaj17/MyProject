using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Encapsulation
{
    class Lid
    {
        public string mtype1;
        public string mtype2;
        public Lid(string mtype1, string mtype2)
        {
            this.mtype1 = mtype1;
            this.mtype2 = mtype2;
        }
        public void show()
        {
            Console.WriteLine("Material Type "+mtype1+" Or "+mtype2);
        }
    }
    class Pen
    {
        int length;
        string color;
        int prize;
        Lid l;
        public Pen(int length,string color,int prize,Lid l)
        {
            this.length = length;   
            this.color = color;
            this.prize = prize;
            this.l = l;
        }
        public void display()
        {
            l.show();
            Console.WriteLine("Length of Pen "+length+" "+"Colour "+color+" "+"Prize "+prize);
        }
    }
    internal class Bag
    {
        string brand_name;
        string color;
        Pen p;
        Bag(string brand_name,string color,Pen p)
        {
            this.brand_name = brand_name;
            this.color=color;
            this.p = p;
        }
        void display()
        {
            p.display();
            Console.WriteLine("Brand Name "+brand_name+" "+" Colour "+color);
        }
        static void Main(string[] args)
        {
            Lid l = new Lid("Glass", "Plastic");
            Pen p = new Pen(4, "Blue", 50,l);
            Bag b = new Bag("Nike", "Black",p);
            b.display();
        }
    }

    //Program For Shippement
    class MyDate
    {
        public int dd;
        public int mm;
        public int yy;
        public MyDate(int dd,int mm,int yy)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }
        public void MyDateshow()
        {
            Console.WriteLine(dd + "  " + mm + "  " + yy);
        }
    }
    class Order
    {
        public int order_id;
        public string cust_name;
        public string city;
        MyDate m;
        public Order(int order_id,string cust_name,string city,MyDate m)
        {
            this.order_id = order_id;
            this.cust_name = cust_name;
            this.city = city;
            this.m = m;
        }
        public void Ordershow()
        {
            m.MyDateshow();
            Console.WriteLine(order_id+"   "+cust_name+"   "+city);
        }
    }
    class Shippment
    {
        public int shippment_id;
        string order;
        Order o;
        public Shippment(int shippment_id,string order,Order o)
        {
            this.shippment_id = shippment_id;
            this.order = order;
            this.o = o;
        }
        public void Shippmentshow()
        {
            o.Ordershow();
            Console.WriteLine(shippment_id+"   "+order);
        }
        static void Main(string[] args)
        {
            Shippment s = new Shippment(25436, "Vehicle", new Order(1254, "Sachin", "Bangalore", new MyDate(14,09,2021)));
            s.Shippmentshow();
        }
    }
}
