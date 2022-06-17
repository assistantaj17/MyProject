using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.OOPS
{
    internal class Bank
    {
        public int accno;
        public string name ,acctype;
        public int amt;

        public void input()
        {
            Console.WriteLine("Enter Account Number");
            accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name");
            name= Console.ReadLine();
            Console.WriteLine("Enter Account Type");
            acctype = Console.ReadLine();
            Console.WriteLine("Enter the Balance Amount");
            amt = Convert.ToInt32(Console.ReadLine());
        }
        public void withdraw()
        {
            Console.WriteLine("Enter the amount you want to withdraw");
            int w = Convert.ToInt32(Console.ReadLine());
            amt = amt - w;
            if (amt == 0 || amt <0)
            {
                Console.WriteLine("You do not have sufficient balance");
                amt = amt + w;
            }
            else
            {
                Console.WriteLine("Balance is " + amt);
            }
        }
        public void deposite()
        {
            Console.WriteLine("Enter the deposite amount");
            int d=Convert.ToInt32(Console.ReadLine());
            amt = amt + d;
            Console.WriteLine("Balance is " + amt);
        }
        public void balance()
        {
            Console.WriteLine("Balance is "+amt);
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            int a = 1;
            char ch;
            b.input();
            do
            {
                if (a < 4)
                {

                    Console.WriteLine("Enter the Number");
                    Console.WriteLine("1 for Withdraw \n 2 for Deposite \n 3 for Account Balance");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        b.withdraw();
                    }
                    else if (n == 2)
                    {
                        b.deposite();
                    }
                    else if (n == 3)
                    {
                        b.balance();
                    }
                    else
                    {
                        Console.WriteLine("Please enter proper input");
                    }
                }
                else
                {
                    Console.WriteLine("In a Day you get only 3 chances");
                    break;
                }
                a++;
                Console.WriteLine("Enter Y for contunue , any key for exit");
                ch = Console.ReadLine()[0];
            }
            while (ch == 'y' || ch == 'Y');
        }
    }

    class Student
    {
        public string name;
        public int id, marks;
        void input(string name,int id,int marks)
        {
            this.name = name;
            this.id = id;
            this.marks = marks;
            display();
        }
        void display()
        {
            Console.WriteLine("\nName "+name+"\nid    "+id+"\nMarks "+marks);
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.input("Ravi", 101, 75);
            //s.display();
            s.input("Surya", 102, 76);
            //s.display();
            s.input("Teja", 103, 80);
            //s.display();
            
        }
    }

    class Overload
    {
        void Calculate(int x,float y)
        {
            Console.WriteLine("Addition is "+(x+y));
        }
        void Calculate(int x,int y)
        {
            Console.WriteLine("Sub "+(x-y));
        }
        void Calculate(float x,float y)
        {
            Console.WriteLine("Multipication "+(x*y));
        }
        void Calculate(float x,int y)
        {
            Console.WriteLine("Division is "+(x/y));
        }
        static void Main(string[] args)
        {
            Overload o=new Overload();
            o.Calculate(2,3.0f);
            o.Calculate(9,6);
            o.Calculate(5.0f,6.0f);
            o.Calculate(30.0f, 5);
        }
    }

    class AreaDemo
    {
        public float pi = 3.14f;
        void Area(int r)
        {
            float a = (float) pi * r * r;
            Console.WriteLine("Area of Circle " + a) ;
        }
        void Area(int w,int h)
        {
            int a = w * h;
            Console.WriteLine("Area of Rectangle "+a);
        }
        void Area(int h,float b)
        {
            float a = (float) (b * h) / 2;
            Console.WriteLine("Area of Triangle "+a);
        }
        void Area(float s)
        {
            float a = s * s;
            Console.WriteLine("Area of Circle " + a);
        }
        static void Main(string[] args)
        {
            AreaDemo ad=new AreaDemo();
            ad.Area(3);
            ad.Area(3,5);
            ad.Area(2,5.0f);
            ad.Area(4.0f);
        }
    }

    class Constructor
    {
        Constructor()
        {
            Console.WriteLine("No Parameter Constructor");
        }
        Constructor(int a)
        {
            Console.WriteLine("One Parameter Constructor");
        }
        Constructor(int a,int b)
        {
            Console.WriteLine("Two Parameter Constructor");
        }
        Constructor(float a)
        {
            Console.WriteLine("One float Parameter Constructor");
        }
        static void Main(string[] args)
        {
            Constructor c1 = new Constructor();
            Constructor c2 = new Constructor(10);
            Constructor c3 = new Constructor(10,20);
            Constructor c4 = new Constructor(5.0f);

        }
    }

    class swapping
    {
        void swap(int a,int b)
        {
            a = a + b;
            Console.WriteLine("After swapping");
            Console.WriteLine(a+" "+b);
        }
        static void Main(string[] args)
        {
            swapping s = new swapping();
            Console.WriteLine("Enter the 1 number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2 number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping");
            Console.WriteLine(num1+" "+num2);
            s.swap(num1, num2);
            Console.WriteLine(num1+" "+num2);
        }
    }

    class Animal
    {
        public virtual void animalsound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
    class pig : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("Pig say : pee  bee");
        }
    }
    class Dog : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("Dog says : bow wow");
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Animal ap = new pig();
            Animal ad = new Dog();
            a.animalsound();
            ap.animalsound();
            ad.animalsound();
        }
    }
}
