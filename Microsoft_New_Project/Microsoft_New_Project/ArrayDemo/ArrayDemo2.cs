using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.ArrayDemo
{
    internal class DescIntArray
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 9, 4, 6, 7, 8, 2 };
            for(int i=0; i<a.Length; i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]<a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            foreach(int p in a)
            {
                Console.WriteLine(p);
            }
        }
    }

    class HalfDescAsc
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 9, 4, 6, 7,1 };
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]<a[j])
                    {
                        int temp=a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for(int i=a.Length/2;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp= a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }

    class SumusingMethod
    {
        public int sumofarray(int [] p)
        {
            int add = 0;
            for(int i=0;i<p.Length;i++)
            {
                add = add + p[i];
            }
            return add;
        }
        static void Main(string[] args)
        {
            SumusingMethod sm = new SumusingMethod();
            int[] a = { 2, 3, 4, 5 };
            int sum=sm.sumofarray(a);
            Console.WriteLine("Sum of array element is "+sum);

        }
    }

    class ToggleCase
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'G', 'r', 'V', 'E', 'W', 'g' };
            Console.WriteLine(String.Join("  ",ch));
            Console.WriteLine("After changing the case of alphabet");
            for(int i=0;i<ch.Length;i++)
            {
                if(ch[i]>='a'&&ch[i]<='z')
                {
                    ch[i] = (char) (ch[i] - 32);
                }
                else
                {
                    ch[i] = (char)(ch[i] + 32);
                }
            }
            /*for(int i=0;i<ch.Length;i++)
            {
                Console.WriteLine(ch[i]);
            }*/
            Console.WriteLine(String.Join("  ",ch));
        }
    }

    class NegativeNoSq
    {
        static void Main(string[] args)
        {
            int[] a = { 4, -2, 5, 3, -7, 3 };
            Console.WriteLine(String.Join("  ",a));
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]<0 && a[i]!=a.Length-1)
                {
                    a[i] = a[i + 1] * a[i + 1];
                }
            }
            Console.WriteLine("--------After ---------");
            Console.WriteLine(String.Join("  ",a));
        }
    }    
}
