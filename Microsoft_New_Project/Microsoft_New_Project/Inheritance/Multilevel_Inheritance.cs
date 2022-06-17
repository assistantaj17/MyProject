using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Inheritance
{
    // 1 Program
    internal class Animal1
    {
        public void bark()
        {
            Console.WriteLine("Barking.....");
        }
    }
    class Dog1 : Animal1
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    class BabyDog : Dog1
    {
        public void sleep()
        {
            Console.WriteLine("Sleeping.....");
        }
    }
    class TestInheritance1
    {
        static void Main(string[] args)
        {
            BabyDog bg = new BabyDog();
            bg.bark();
            bg.eat();
            bg.sleep();
        }
    }

    // 2 Program
    class Vehicle1
    {
        public void type()
        {
            Console.WriteLine("Lot of types");
        }
    }

    class Car1 : Vehicle1
    {
        public void tyre()
        {
            Console.WriteLine(" 4 Wheeler Car ");
        }
    }
    class SportCar : Car1
    {
        public void speed()
        {
            Console.WriteLine("It has maximum speed");
        }
    }
    class TestInheritance2
    {
        static void Main(string[] args)
        {
            SportCar sc = new SportCar();
            sc.type();
            sc.tyre();
            sc.speed();
        }
    }

    // 3 Program
    class GrandFather
    {
        public void show()
        {
            Console.WriteLine("Base Class ");
        }
    }
    class Father : GrandFather
    {
        public void display()
        {
            Console.WriteLine("Intermediate class");
        }
    }
    class Son : Father
    {
        public void displaY()
        {
            Console.WriteLine("Derived Class");
        }
        static void Main(string[] args)
        {
            Son s = new Son();
            s.show();
            s.display();
            s.displaY();
        }
    }
}
