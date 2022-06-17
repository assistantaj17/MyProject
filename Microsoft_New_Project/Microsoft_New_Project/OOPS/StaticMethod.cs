using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.OOPS
{
    internal class StaticMethod
    {
        
        static void display()
        {
            Console.WriteLine("Default static method");
        }
        static void display(int a)
        {
            Console.WriteLine("Static method Overload with 1 parameter");
        }
        static void display(int a, int b)
        {
            Console.WriteLine("Static method Overload with 2 parameter");
        }
        static void Main(string[] args)
        {
            display();
            display(3);
            display(1,2);
        }
    }

    class StaticDemo1
    {
        static int x = 100;
        int y = 20;
        public void Addition()
        {
            Console.WriteLine(x+y);
        }
        public static void Division()
        {
            StaticDemo1 demo = new StaticDemo1();
            Console.WriteLine(x/demo.y);
        }
        static void Main(string[] args)
        {
            StaticDemo1 demo = new StaticDemo1();
            demo.Addition();
            Division();
        }
    }

    class StaticDemo2
    {
        static void Main(string[] args)
        {
            StaticDemo1 d1 = new StaticDemo1();
            d1.Addition();
            StaticDemo1.Division();
        }
    }

    //static class StaticDemo3
    //{
    //    StaticDemo3()
    //    {

    //    }
    //    private StaticDemo3(int a)
    //    {

    //    }
    //    static void Main(string[] args)
    //    {
    //        StaticDemo3 d3=new StaticDemo3();
    //    }
    //}


}
