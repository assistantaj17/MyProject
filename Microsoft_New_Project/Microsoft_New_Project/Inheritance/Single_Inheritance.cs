using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Inheritance
{
    // 1 Program
    internal class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating.....");
        }
    }
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking....");
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            d.bark();
        }
    }
    // 2 Program
    class Fruit
    {
        public void display()
        {
            Console.WriteLine("Base class");
        }
    }
    class Apple : Fruit
    {
        public void show()
        {
            Console.WriteLine("Derived Class");
        }
        static void Main(string[] args)
        {
            Apple a = new Apple();
            a.display();
            a.show();
        }
    }
    // 3 Program
    class Vehicle
    {
        public void type()
        {
            Console.WriteLine("Different type of vehicle ");
        }
    }
    class Car : Vehicle
    {
        public void color()
        {
            Console.WriteLine("Car has different color");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.type();
            c.color();
        }
    }
}
