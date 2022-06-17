using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project
{
    internal class Pattern1
    {
        static void Main(string[] args)
        {
            for(int i=4;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern2
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=4;j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern3
    {
        static void Main(string[] args)
        {
            int k = 1;
            for(int i=1;i<=3;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(k++);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern4
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    if(i==1||i==4||j==1||j==4)
                    {
                        Console.Write("*");
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

    class Pattern5
    {
        static void Main(string[] args)
        {
            int k = 1;
            for(int i=1;i<=10;i++)
            {
                for(int j=1;j<=k;j++)
                {
                    Console.Write("*");
                }
                int v = (i <= 5) ? k++ : k--;
                Console.WriteLine();
            }
        }
    }

    class Pattern6
    {
        static void Main(string[] args)
        {
            
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(j%2!=0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j==1 || i==5 || j==i)
                    {
                        Console.Write("*");
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

    class Pattern8
    {
        static void Main(string[] args)
        {
            int k = 5, n = 5;
            for( int i = 1; i<=5; i++)
            {
                for(int j=1;j<10;j++)
                {
                    if (j >= k && j <= n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                k--;
                n++;
                Console.WriteLine();
            }
        }
    }

    class Pattern9
    {
        static void Main(string[] args)
        {
            int k = 5, n = 5,l=1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j >= k && j <= n)
                    {
                        Console.Write(l);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                k--;
                n++;
                l += 2;
                Console.WriteLine();
            }
        }
    }

    class PatternN
    {
        static void Main(string[] args)
        {
            int k = 1;
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if(j==1 || j==5 || j==k)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                k++;
                Console.WriteLine();
            }
        }
    }
}
