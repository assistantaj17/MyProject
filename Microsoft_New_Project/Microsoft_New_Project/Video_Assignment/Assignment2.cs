using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Video_Assignment
{
    internal class EvenFrom121to229
    {
        static void Main(string[] args)
        {
            for (int i = 122; i <= 229; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }

    class OddFrom521to229
    {
        static void Main(string[] args)
        {
            for (int i = 521; i >= 229; i = i - 2)
            {
                Console.WriteLine(i);
            }
        }
    }

    class UseofBreak
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine(i);
            }
        }
    }

    class GCD_and_LCM
    {
        static void Main(string[] args)
        {

        }
    }

    class PrintAlphabet
    {
        static void Main(string[] args)
        {
            char ch;
            for (int i = 97; i < 123; i++)
            {
                ch = (char)i;
                Console.WriteLine(ch);
            }
        }
    }

    class SumofAllEven
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 20; i = i + 2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }

    class SumofAllOdd
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i = i + 2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }

    class CountNumDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while (num > 0)
            {
                int rem = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine("Digit in number is " + count);
        }
    }

    class ProductofDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int mul = 1;
            while (num > 0)
            {
                int rem = num % 10;
                mul = mul * rem;
                num = num / 10;
            }
            Console.WriteLine("Product of Digit is " + mul);
        }
    }

    class FrequencyofDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());

        }
    }

    class PrimeNumBet400_300
    {
        static void Main(string[] args)
        {
            int count=0;
            Console.WriteLine("Prime Number Between 400 to 300");
            for (int i = 400; i >= 300; i--)
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

    class TableofNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num= Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num+" * "+i+" = "+(i*num));
            }
        }
    }

    class Squarefrom1_20
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine(i*i);
            }
        }
    }

    class Power1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the exponential");
            int e = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            for(int i = 1; i <= e; i++)
            {
                p = p * b;
            }
            Console.WriteLine(b+" Power of "+e+"  =  "+p);
        }
    }

    class SumofFactor1ToN
    {
        static void Main(string[] args)
        {
            int sum = 0, mul = 1;
            for(int i = 1; i < 6; i++)
            {
                mul = 1;
                for(int j=1;j<=i;j++)
                {
                    mul = mul * j;
                }
                sum = sum + mul;
            }
            Console.WriteLine("Sum of Factor is "+sum);
        }
    }

    class KrishnamurthyNo   //  145
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = 0, sum = 0, mul = 1;
            temp = num;
            while(temp>0)
            {
                mul = 1;
                int rem = temp % 10;
                for(int i=1;i<=rem;i++)
                {
                    mul = mul * i;
                }
                sum = sum + mul;
                temp = temp / 10;
            }
            if(sum==num)
            {
                Console.WriteLine("Krishnamurthy Number");
            }
            else
            {
                Console.WriteLine("Not Krishnmurthy Number");
            }
        }
    }

    class PalindromeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = 0,revs = 0;
            temp = num;
            while(temp>0)
            {
                int rem = temp % 10;
                revs = (revs * 10) + rem;
                temp = temp / 10;
            }
            if(num==revs)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not Palindrome Number");
            }
        }
    }

    class AutomorphicNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sq = 0;
            sq = num * num;
            bool flag = true;
            while(num>0)
            {
                if(num%10 == sq%10)
                {
                    num = num / 10;
                    sq = sq / 10;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("Not Automorphic");
            }
        }
    }

    class Harshed_NivenNo  //18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num= Convert.ToInt32(Console.ReadLine());
            int temp = 0, sum = 0;
            temp = num;
            while(temp>0)
            {
                int rem = temp % 10;
                sum = sum + rem;
                temp = temp / 10;
            }
            if(num%sum==0)
            {
                Console.WriteLine("Harshed/Niven No");
            }
            else
            {
                Console.WriteLine("Not Harshed/Niven No");
            }
        }
    }
    class AllPalindromefrom100_500
    {
        static void Main(string[] args)
        {
            for(int i=100;i<=500;i++)
            {
                int num = i, revs = 0;
                while(num>0)
                {
                    int rem=num % 10;
                    revs = (revs * 10) + rem;
                    num = num / 10;
                }
                if(i==revs)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
