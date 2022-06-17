using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.ArrayDemo
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            int[] a = { 20,50,60,10,40 };
            // { 3,4,6,7)
            int p = a.Length ;
            int n=a.Length/2 ;
            Console.WriteLine("Original Array");
            Console.WriteLine(String.Join("   ",a));
            if(p%2==0)
            {
                for(int i=0;i<n;i++)
                {
                    int imag = a[i];
                    a[i] = a[n + i];
                    a[n + i] = imag;
                }
            }
            else
            {
                for (int i = 0; i < a.Length / 2; i++)
                {


                    int temp = a[i];
                    a[i] = a[n + i + 1];
                    a[n + i + 1] = temp;


                }
            }
            Console.WriteLine("Array After Changing");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+"   ");
            }
            
        }
    }
}
