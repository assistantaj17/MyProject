using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Basic
{
    internal class Blo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18 && age < 70)
            {
                Console.WriteLine("You are eligible for Blood Donation");
            }
            else
            {
                Console.WriteLine("You are not eligible for Blood Donation");
            }
        }
    }

    class Lo1
    {
        static void Main(string[] args)
        {
            for (int i = 125; i >= 85; i--)
            {
                Console.Write(i + "  ");
            }
        }
    }

    class Lo2
    {
        static void Main(string[] args)
        {
            for (int i = 35; i <= 75; i++)
            {
                Console.Write(i + "  ");
            }
        }
    }

    class Lo3
    {
        static void Main(string[] args)
        {
            for (int i = 25; i <= 45; i = i + 2)
            {
                Console.Write(i + "  ");
            }
        }
    }

    class COd
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 20; i = i + 2)
            {
                count++;
            }
            Console.WriteLine("Count is " + count);
        }
    }

    class Tae
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                int mul;
                mul = i * num;
                Console.WriteLine(num + " * " + i + " = " + mul);
                i++;
            }
        }
    }

    class Po1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the exponant");
            int exp = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            for (int i = 1; i <= exp; i++)
            {
                power = power * num;
            }
            Console.WriteLine("Power is " + power);
        }
    }

    class Prum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
        }
    }

    class Fac1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of Factor is " + sum);
        }
    }

    class Fac2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int mul = 1;
            for (int i = 1; i <= num; i++)
            {
                mul = mul * i;
            }
            Console.WriteLine("Mul of Factor is " + mul);
        }
    }

    class Elll
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter unit");
            int unit = int.Parse(Console.ReadLine());
            float rs = 0.0f;
            if (unit <= 50)
            {
                rs = (float)(unit * 0.50);
                Console.WriteLine("Total Rs is " + rs);
            }
            else if (unit <= 100)
            {
                rs = (float)(unit * 0.75);
                Console.WriteLine("Total Rs is " + rs);
            }
            else if (unit <= 200)
            {
                rs = (float)(unit * 1.20);
                Console.WriteLine("Total Rs is " + rs);
            }
            else
            {
                rs = (float)(unit * 1.50);
                float surcharge;
                surcharge = (float)(20 / 100) * (float)rs;
                Console.WriteLine("Total Rs is " + (rs + surcharge));
            }
        }
    }

    class Sary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your basic salary");
            double basic = double.Parse(Console.ReadLine());
            double hra, da, total;
            if (basic <= 10000)
            {
                hra = 20 / 100 * basic;
                da = 80 / 100 * basic;
                total = basic + hra + da;
                Console.WriteLine("HRA " + hra);
                Console.WriteLine("DA " + da);
                Console.WriteLine("Total Salary is " + total);
            }
            else if (basic <= 20000)
            {
                hra = (25 / 100) * basic;
                da = (90 / 100) * basic;
                total = basic + hra + da;
                Console.WriteLine("Total Salary is " + total);
            }
            else if (basic > 20000)
            {
                hra = (30 / 100) * basic;
                da = (95 / 100) * basic;
                total = basic + hra + da;
                Console.WriteLine("Total Salary is " + total);
            }
            else
            {
                Console.WriteLine("Enter proper input");
            }
        }
    }
}
