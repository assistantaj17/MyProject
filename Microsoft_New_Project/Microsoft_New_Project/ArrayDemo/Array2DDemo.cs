using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.ArrayDemo
{
    internal class Array2DSum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2 }, { 3, 4 } };
            int[,] b = { { 8, 5 }, { 2, 1 } };
            int[,] c = new int[2,2];
            for(int i=0; i<=a.GetUpperBound(0); i++)
            {
                for(int j=0; j<=a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for(int i=0;i<=b.GetUpperBound(0);i++)
            {
                for(int j=0;j<=b.GetUpperBound(1);j++)
                {
                    Console.Write(b[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("/////////////////////");
            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    c[i,j] = a[i, j] + b[i, j];
                }
            }

            for(int i=0;i<=c.GetUpperBound(0);i++)
            {
                for(int j=0;j<=c.GetUpperBound(1);j++)
                {
                    Console.Write(c[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class ColwiseSum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 } };
            int[] csum = new int[10];
            int i = 0, j = 0;
            for(i=0;i<a.GetLength(0);i++)
            {
                for(j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]+"   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------");
            for(i=0;i<a.GetLength(0);i++)
            {
                csum[i] = 0;
                for(j=0;j<a.GetLength(1);j++)
                {
                    csum[i] = csum[i] + a[j, i];
                }                                       
                Console.Write(csum[i]+"  ");          
                //Console.WriteLine();                   
            }
        } 
    }

    class RowWiseAVG
    {
        static void Main(string[] args)
        {
            int[,] a = { { 2, 3, 4,2 }, { 3,5, 6, 7 },{5,8,1,9 } };
            Console.WriteLine(a.GetLength(0));
            Console.WriteLine(a.GetLength(1));
            Console.WriteLine("???????/////");
            for(int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0,avg=0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[i, j];
                    avg = sum / a.GetLength(1);
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine("= "+avg);
                Console.WriteLine();
            }
        }
    }

    class N_Pattern
    {
        static void Main(string[] args)
        {
            int[,] a = { { 4, 6, 5,4,6 }, {2, 7, 4, 9,5 }, {5, 2, 6, 4,9 },{6, 3,6,4,7},{ 1,2,3,4,5} };
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    if((j==0) || (i==j) || (j==a.GetUpperBound(1)))
                    {
                        Console.Write(a[i,j]);
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

    class TransposeMatrix
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } };
            int[,] b = new int[20,20];
            for(int i=0; i<=a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    b[j, i] = a[i, j];
                }
                
            }
            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    Console.Write(b[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
