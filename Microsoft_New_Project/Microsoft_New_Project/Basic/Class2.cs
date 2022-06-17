using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Basic
{
    internal class Po
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the exponant");
            int exp = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            for (int i = exp; i >= 1; i--)
            {
                power = power * num;
            }
            Console.WriteLine("Power of " + num + " exponance " + exp + " is " + power);
        }
    }

    class Prim
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
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is Not Prime");
            }
        }
    }

    class PrimPos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the position");
            int pos = Convert.ToInt32(Console.ReadLine());
            int count, pri = 0;
            for (int i = 2; i < 500; i++)
            {
                count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    pri++;
                    if (pos == pri)
                    {
                        Console.WriteLine("prime number on position " + pos + " is " + i);
                        break;
                    }
                }
            }
        }
    }
}
