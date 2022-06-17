using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Basic
{
    internal class A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            sum = num1 + num2;
        }
    }

    class Ad
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                sum = num1 + num2;
                Console.WriteLine("Addition is " + sum);
                Console.WriteLine("press y for continue or any other key for exit ");
                char ch = Console.ReadLine()[0];
                if (ch == 'y' || ch == 'Y')
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }

    class Su
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int sub = 0;
                sub = num1 - num2;
                Console.WriteLine("Substraction is " + sub);
                Console.WriteLine("press y for continue or any other key for exit ");
                char ch = Console.ReadLine()[0];
                if (ch == 'y' || ch == 'Y')
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }

    class Mu
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int mul = 0;
                mul = num1 * num2;
                Console.WriteLine("Multiplication  is " + mul);
                Console.WriteLine("press y for continue or any other key for exit ");
                char ch = Console.ReadLine()[0];
                if (ch == 'y' || ch == 'Y')
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }

    class Di
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int div = 0;
                if (num2 == 0)
                {
                    Console.WriteLine("Please do not divide by zero");
                }
                else
                {
                    div = num1 / num2;
                    Console.WriteLine("Division is " + div);
                }
                Console.WriteLine("press y for continue or any other key for exit ");
                char ch = Console.ReadLine()[0];
                if (ch == 'y' || ch == 'Y')
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }

    class ARe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breath");
            int breath = Convert.ToInt32(Console.ReadLine());
            float area = 0.0f;
            area = (float)length * breath;
            Console.WriteLine("Area of rectangle is " + area);
        }
    }

    class AT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height");
            float h = Convert.ToInt32(Console.ReadLine());
            float area;
            area = (b * h) / 2;
            Console.WriteLine("Area of Triangle " + area);
        }
    }

    class Sqe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sq;
            sq = num * num;
            Console.WriteLine("Square is " + sq);
        }
    }

    class ue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int cube;
            cube = num * num * num;
            Console.WriteLine("Cube is " + cube);
        }
    }

    class Cent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length in centimeter");
            float l = Convert.ToInt32(Console.ReadLine());
            float metre, km;
            metre = l / 100;
            km = l / 100000;
            Console.WriteLine(l + " cm is " + metre + " metre");
            Console.WriteLine(l + " cm is " + km + " km");

        }
    }

    class Cla
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks of first subject");
            float marks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of second subject");
            float marks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of third subject");
            float marks3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of fourth subject");
            float marks4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of fifth subject");
            float marks5 = Convert.ToInt32(Console.ReadLine());
            float sum, avg, per;
            sum = marks1 + marks2 + marks3 + marks4 + marks5;
            avg = sum / 5;
            per = (sum / 500) * 100;
            Console.WriteLine("Total Marks is " + sum);
            Console.WriteLine("Average Marks is " + avg);
            Console.WriteLine("Percentage is " + per);
        }
    }

    class Sinst
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Principle Amount");
            float p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest");
            float r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time in year");
            float t = Convert.ToInt32(Console.ReadLine());
            float si;
            si = (p * r * t) / 100;
            Console.WriteLine("Simple Interest is " + si);
        }
    }

    class Pre
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            float l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breath");
            float b = Convert.ToInt32(Console.ReadLine());
            float pm;
            pm = 2 * (l + b);
            Console.WriteLine("Perimetre of Rectangle is " + pm);
        }
    }
}
