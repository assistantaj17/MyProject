using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Basic
{
    internal class Table1to5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
            }
        }
    }

    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sq;
            sq = num * num;
            bool flag = false;
            while (num > 0)
            {
                if (num % 10 == sq % 10)
                {
                    flag = true;
                    num = num / 10;
                    sq = sq / 10;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("Not Automorphic");
            }
        }
    }

    class Disarium
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num, count = 0, sum = 0, mul = 1;
            while (temp > 0)
            {
                //int rem = temp % 10;
                count++;
                temp = temp / 10;
            }
            temp = num;
            while (temp > 0)
            {
                mul = 1;
                int rem = temp % 10;
                for (int i = 1; i <= count; i++)
                {
                    mul = mul * rem;
                }
                temp = temp / 10;
                sum = sum + mul;
                count--;
            }
            if (num == sum)
            {
                Console.WriteLine("Number is Disarium");
            }
            else
            {
                Console.WriteLine("Number is Not Disarium");
            }
        }
    }

    class Trimorpc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            long cube;
            bool flag = false;
            int temp = num;
            cube = num * num * num;
            while (temp > 0)
            {
                if (temp % 10 == cube % 10)
                {
                    flag = true;
                    temp = temp / 10;
                    cube = cube / 10;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Trimorphic");
            }
            else
            {
                Console.WriteLine("Not Trimorphic");
            }
        }
    }

    class Kaprekar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sq, rem, sum = 0, mul = 1;
            int count = 0, temp, count1 = 0;
            sq = num * num;
            temp = num;
            while (temp > 0)
            {
                int r = temp % 10;
                count++;
                temp = temp / 10;
            }
            while (sq > 0)
            {
                if (count != count1)
                {
                    rem = sq % 10;
                    sum = sum + (mul * rem);
                    mul = mul * 10;
                    sq = sq / 10;
                    count1++;
                }
                else
                {
                    break;
                }
            }
            int add = sum + sq;
            if (num == add)
            {
                Console.WriteLine("Kaprekar Number");
            }
            else
            {
                Console.WriteLine("Not Kaprekar Number");
            }
        }
    }

    class PrimeNo1To10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            Console.WriteLine("Prime Number between " + num1 + " to " + num2 + " is ");
            for (int i = num1; i <= num2; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
