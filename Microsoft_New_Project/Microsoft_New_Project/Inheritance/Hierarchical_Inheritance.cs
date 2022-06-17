using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Inheritance
{
/*
    internal class A
    {
        public void display()
        {
            Console.WriteLine("A class Method");
        }
    }
    class B : A
    {
        public void display()
        {
            Console.WriteLine("B class Method");
        }
    }
    class C : A
    {
        public void display()
        {
            Console.WriteLine("C class Method");
        }
    }
    class MyProgram
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.display();
            B b = new B();
            b.display();
            A ac = new C();
            ac.display();
        }
    }*/

    class Mathh
    {
         int kl;
        Mathh(int n)
        {
            kl = n;
        }
        static void Main(string[] args)
        {
            Mathh m = new Mathh(746);
        }
    }

    class ABC
    {
        public void run()
        {
            Console.WriteLine("ABC class is running....");
        }
    }
    class PQR : ABC
    {
        public void run()
        {
            Console.WriteLine("PQR class is running.....");
        }
    }
    class XYZ
    {
        static void Main(string[] args)
        {
            PQR p = new PQR();
            p.run();
            ABC a = new ABC();
            a.run();
            ABC ap = new PQR();
            ap.run();
        }
    }

}
