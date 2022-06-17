using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.ArrayDemo
{
    internal class MinElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int min = 0;
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int x in a)
            { 
                Console.Write(x + "  ");
            }
            min = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(min>a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Min value is "+min);
        }
    }

    internal class AvgofElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int avg = 0,sum=0;
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int x in a)
            {
                Console.Write(x + "  ");
            }
            
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            avg = sum / a.Length;
            Console.WriteLine();
            Console.WriteLine("Average is  " + avg);
        }
    }

    internal class PositionofElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int x in a)
            {
                Console.Write(x + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter the element");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==num)
                {
                    Console.WriteLine("Position of " + num + " in given array is " + (i+1));
                    break;
                }
            }
            
        }
    }

    internal class OccuranceofElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int x in a)
            {
                Console.Write(x + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter the element");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    count++;
                }
            }
            Console.WriteLine("Occurance of given number in array is "+count);
        }
    }

    class MergeArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of 1 array");
            int size1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of 2 array");
            int size2=int.Parse(Console.ReadLine());
            int[] a1 = new int[size1];
            int [] a2=new int[size2];
            int[] a3 = new int[size1 + size2];
            int i = 0, j = 0;
            Console.WriteLine("Enter the element in 1 array");
            for(i=0;i<a1.Length;i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element in 2 array");
            for(i=0;i<a2.Length;i++)
            {
                a2[i] = int.Parse(Console.ReadLine());
            }
            for(i = 0,j=0; i < a1.Length; i++)
            {
                a3[j++] = a1[i];
            }
            for(i = 0; i < a2.Length; i++)
            {
                a3[j++] = a2[i];
            }
            Console.WriteLine("First array Element");
            Console.WriteLine(String.Join("  ",a1));
            Console.WriteLine("Second array element");
            Console.WriteLine(String.Join("  ",a2));
            Console.WriteLine("Merging of two array element");
            for(i=0;i<a3.Length;i++)
            {
                Console.WriteLine(a3[i]);
            }
        }
    }

    class AlternateMergeArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of 1 array");
            int size1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of 2 array");
            int size2 = int.Parse(Console.ReadLine());
            int[] a1 = new int[size1];
            int[] a2 = new int[size2];
            int[] a3 = new int[size1 + size2];
            int n = 1;
            while(n!=0)
            {
                if(size1!=size2)
                {
                    Console.WriteLine("Both Array must be same in size");
                    break;
                }
                int i = 0, j = 0;
                Console.WriteLine("Enter the element in 1 array");
                for (i = 0; i < a1.Length; i++)
                {
                    a1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the element in 2 array");
                for (i = 0; i < a2.Length; i++)
                {
                    a2[i] = int.Parse(Console.ReadLine());
                }
                for (i = 0, j = 0; i < a1.Length; i++)
                {
                    a3[j++] = a1[i];
                    a3[j++] = a2[i];
                }
                Console.WriteLine("First array Element");
                Console.WriteLine(String.Join("  ", a1));
                Console.WriteLine("Second array element");
                Console.WriteLine(String.Join("  ", a2));
                Console.WriteLine("Merging of two array element");
                for (i = 0; i < a3.Length; i++)
                {
                    Console.WriteLine(a3[i]);
                }
                n--;
            }
        }
    }

    class SumofPrimeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6, 8, 5, 7 };
            int sum = 0;
            bool isPrime = true;
            int n;
            for(int i=0; i < a.Length; i++)
            {
                isPrime = true;
                //n = a[i];
                for(int j=2;j<a[i];j++)
                {
                    if(a[i]%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("Addition of Prime Number "+sum);

        }
    }
}
