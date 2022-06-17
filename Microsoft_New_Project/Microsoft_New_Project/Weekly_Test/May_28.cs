using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Weekly_Test
{
    internal class Number1To100
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + "  ");
                }
            }
        }
    }

    class Output1
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }

    class Output2
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k= " + k + " i= " + i);
        }
    }

    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, mul = 1;
            while (num > 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                mul = mul * rem;
                num = num / 10;
            }
            if (sum == mul)
            {
                Console.WriteLine("Spy Number");
            }
            else
            {
                Console.WriteLine("Not Spy Number");
            }
        }
    }

    class Trimorphic
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

    class Pattern1234
    {
        static void Main(string[] args)
        {
            int k = 4, l = 4;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    if (j >= k && j <= l)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                k--;
                l++;
                Console.WriteLine();
            }
        }
    }
    class Patterndown
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 8 - 1 - i; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern1to5
    {
        static void Main(string[] args)
        {
            int k;
            for (int i = 1; i <= 5; i++)
            {
                k = 1;
                for (int j = 1; j <= 5; j++)
                {
                    if (j >= i)
                    {
                        Console.Write(k++);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Output3
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }

    class TwinPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int p = 1, q = 1;
            for (int i = 2; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    p = 0;
                    break;
                }
            }
            for (int i = 2; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    q = 0;
                    break;
                }
            }
            if (p == q)
            {
                int sub = num1 - num2;
                if ((sub == -2) || (sub == 2))
                {
                    Console.WriteLine("Both are Twin Prime Number");
                }
                else
                {
                    Console.WriteLine("Prime But Not Twin Prime");
                }
            }
            else
            {
                Console.WriteLine("Both are not Twin Prime Number");
            }

        }
    }

    class Series
    {
        static void Main(string[] args)
        {
            int sq = 0, cube = 0, sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sq = i * i;
                cube = i * i * i;
                sum = sq + cube;
                Console.WriteLine(sum);
            }
        }
    }

    class OddEven
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(-(i * i) + " ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

    class Output4
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }
        }
    }

    class Fibbo
    {
        static void Main(string[] args)
        {
            int sum = 0, a = 1, b = 0, c = 0;
            Console.WriteLine(b);
            while (c < 10)
            {
                sum = a + b;
                a = b;
                b = sum;
                Console.WriteLine(sum);
                c++;
            }
        }
    }

    class SumofFactor
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 4; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }
                sum = sum + fact;
            }
            Console.WriteLine(sum); ;
        }
    }
}
