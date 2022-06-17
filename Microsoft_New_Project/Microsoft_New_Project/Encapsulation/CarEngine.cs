using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Encapsulation
{
    // Program using Property (Car class and Engine Class)
    class Engine
    {
        private string engine_type1;
        private string engine_type2;
        public string Engine_type1
        {
            get { return engine_type1; }
            set { engine_type1 = value; }
        }
        public string Engine_type2
        {
            get { return engine_type2; }
            set { engine_type2 = value; }
        }
        public void display()
        {
            Console.WriteLine(engine_type1+" "+engine_type2);
        }
    }
    internal class Car
    {
        private string name;
        private string color;
        private int prize;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Prize
        {
            get { return prize; }
            set { prize = value; }
        }
        public void display()
        {
            Console.WriteLine(name+" "+color+" "+prize);
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            c.name = "BMW";
            c.color = "Black";
            c.prize = 5100500;
            Engine e = new Engine();
            e.Engine_type1 = "Petrol";
            e.Engine_type2 = "Diesel";
            c.display();
            e.display();

        }
    }
    // Program using Constructor ( Car class and Engine Class )
    class Engiine
    {
        private string engtype1;
        private string engtype2;
        public Engiine(string engtype1,string engtype2)
        {
            this.engtype1 = engtype1;
            this.engtype2 = engtype2;
        }
        public void display()
        {
            Console.WriteLine(engtype1+" "+engtype2);
        }
    }
    class Carr
    {
        private string name;
        private string color;
        private int prize;
        Engiine e;
        public Carr(string name,string color,int prize,Engiine e)
        {
            this.name = name;
            this.color = color;
            this.prize = prize;
            this.e = e;
        }
        public void display()
        {
            Console.WriteLine(name+" "+color+" "+prize);
            e.display();
        }
        static void Main(string[] args)
        {
            //Engiine e = new Engiine("Petrol", "Diesel");
            //Carr c = new Carr("AUDI", "Black", 4500000);
            Carr c = new Carr("AUDI", "Silver", 4500000, new Engiine("Petrol","Diesel"));
            c.display();
        }
    }


}
