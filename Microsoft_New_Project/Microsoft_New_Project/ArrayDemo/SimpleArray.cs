using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.ArrayDemo
{
    internal class EvenElemeentArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the element");
            for(int i = 0; i < a.Length; i++)
            {
                int b=Convert.ToInt32(Console.ReadLine());
                a[i] = b;
            }
            Console.WriteLine("Even Element in array");
            for(int i=0; i < a.Length; i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }

    internal class OddPositionElemeent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the element");
            for (int i = 0; i < a.Length; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                a[i] = b;
            }
            Console.WriteLine("Element in array are ");
            foreach(int x in a)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Odd Position Element in array");
            for (int i = 1; i < a.Length; i=i+2)
            {
                Console.WriteLine(a[i]);
            }
        }
    }

    internal class AlternatePositionElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the element");
            for (int i = 0; i < a.Length; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                a[i] = b;
            }
            Console.WriteLine("Element in array are ");
            foreach (int x in a)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Alternate Position Element in array");
            for (int i = 0; i < a.Length; i = i + 2)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
