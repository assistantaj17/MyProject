using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Weekly_Test
{
    // Program 01
    internal class CountEvenandOddNo
    {
        static void Main(string[] args)
        {
            int[] a = { 25, 14, 36, 59, 86, 57, 42, 51, 35 };
            int ecount = 0, ocount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]%2==0)
                {
                    ecount++;
                }
                else
                {
                    ocount++;
                }
            }
            Console.WriteLine("Even Number = "+ecount);
            Console.WriteLine("Odd NUmber = "+ocount);
        }
    }
    // Program 02
    class Test_Output
    {
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if(n>100)
            {
                return n - 10;
            }
            else
            {
                return mcCarthy(n + 11);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(mcCarthy(100)+"   "+mcCartyCounter);
        }
    }
    // Program 03
    class MINFreqchar
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'b', 'c', 'c', 'b' };
            int count = 0, freq = arr.Length;
            char ch=' ';
            for(int i=0;i<arr.Length;i++)
            {
                count = 0;
                for(int j=0;j<arr.Length;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        count++;
                    }
                }
                if(freq>count)
                {
                    freq = count;
                    ch = arr[i];
                }
            }
            Console.WriteLine(ch+"   "+freq);
        }
    }
    // Program 04 
    class Nib
    {
        private string materialType;
        private double width;
        public string MatrialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public void show()
        {
            Console.WriteLine("Material Type "+materialType+" Width in mm "+width);
        }
    }
    class Refill
    {
        private string inkColor;
        private int length;
        Nib n;
        public string InkColor
        {
            get { return inkColor; }
            set { inkColor = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib N
        {
            get { return n; }
            set { n = value; }
        }
        public void show1()
        {
            n.show();
            Console.WriteLine("InkColor "+inkColor+"Length "+length);
        }
    }
    class Pen
    {
        private int capLength;
        private string brand;
        Refill r;
        public int CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Refill R
        {
            get { return r; }
            set { r = value; }
        }
        public void show2()
        {
            r.show1();
            Console.WriteLine("CapLength "+capLength+" Brand "+brand);
        }
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.capLength = 10;
            p.brand = "Cello";
            p.r = new Refill();
            Refill re = p.r;

            p.show2();
        }
    }
    // Program No 06
    class SeparateZero
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };   //{ 12,7,8,3,0,0,0 } {12 0 7 0 8 0 3}
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length-1;j++)
                {
                    if(arr[j]==0)
                    {
                        int temp = arr[j+1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(" ",arr));
        }
    }
    // Program No 07
    class RemoveDup
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 4, 9, 2 };  // {4,3,2,9}
            Console.WriteLine("Original Array");
            Console.WriteLine(String.Join(" ",arr));
            Console.WriteLine("After Removing Element ");
            for(int i=0;i<arr.Length-1;i++)
            {
                int count = 1;
                bool isvisited = true;
                for(int k=i-1;k>=0;k--)
                {
                    if(arr[k]==arr[i])
                    {
                        isvisited = false;
                        break; 
                    }
                }
                if(isvisited)
                {
                    for(int j=i+1;j<arr.Length;j++)
                    {
                        if(arr[i]==arr[j])
                        {
                            count++;
                        }
                    }
                    Console.Write(arr[i]+" ");
                }
            }
        }
    }
    // Program 08
    class SubEngine
    {
        private string subengtype;
        public SubEngine(string subengtype)
        {
            this.subengtype = subengtype;
        }
        public void show()
        {
            Console.WriteLine("Sub Engine Type " + subengtype);
        }
    }
    class Engine
    {
        private int engineid;
        private string lastcleanupdate;
        SubEngine sub;
        public Engine(int engineid,string lastcleanupdate,SubEngine sub)
        {
            this.engineid = engineid;
            this.lastcleanupdate = lastcleanupdate;
            this.sub = sub;
        }
        public void show1()
        {
            sub.show();
            Console.WriteLine("Engine_Id "+engineid+" Last Clean Up Date "+lastcleanupdate);
        }
    }
    class Gear
    {
        private string type1;
        private string type2;
        public Gear(string type1,string type2)
        {
            this.type1 = type1;
            this.type2 = type2;
        }
        public void display()
        {
            Console.WriteLine("Type1 "+type1+" Type2 "+type2);
        }
    }
    class Car
    {
        private int carid;
        private string carcolor;
        Engine e;
        public Car(int carid,string carcolor,Engine e)
        {
            this.carid = carid;
            this.carcolor = carcolor;
            this.e = e; 
        }
        public void show2()
        {
            e.show1();
            Console.WriteLine(" Carid "+carid+" Carcolor "+carcolor);
        }
        static void Main(string[] args)
        {
            SubEngine sb = new SubEngine("Diesel");
            Engine e = new Engine(5243, "22-011-2021",sb );
            Car c = new Car(20548, "Red", e);
            //Car c = new Car(2365, "Red", new Engine((6849, "16-1-2022"), new SubEngine("Diesel")));
            c.show2();
            Gear g = new Gear("Auto","Manual");
            g.display();
        }
    }
    // Program 09
    class Number_Output
    {
        static void Main(string[] args)
        {
            int [] var = new int[10];
            for(int i=0;i<10;++i )
            {
                var[i] = i;
                Console.WriteLine(var[i]+"  ");
                i++;
            }
        }
    }
    // Program 10
    class PerfectsqNum
    {
        static void Main(string[] args)
        {
            int[] a = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 }; // { 25,49,9 }
            for(int i=0;i<a.Length;i++)
            {
                int n = a[i];
                for(int j=1;j<n;j++)
                {
                    if(n==j*j)
                    {
                        Console.WriteLine(n);
                        break;
                    }
                }
            }
        }
    }
    // Program 11
    /*class Array_Output
    {
        static void Main(string[] args)
        {
            
            int [] a1 ={ 1,2,3};
            int [] a2 = new String[a1.Length];
            for(int i=0;i<a1.Length;i++)
            {
                a2[i] = a1[i];
            }
            for(int i=0;i<a2.Length;i++)
            {
                Console.WriteLine(a2[i]);
            }
        }
    }*/
    // Program 12
    class Replace0to1
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==0)
                {
                    a[i] = 1;
                }
            }
            Console.WriteLine(String.Join(" ",a));
        }
    }
    // Program 13
    class BuzzFizz
    {
        static void Main(string[] args)
        {
            int bcount = 0, fcount = 0, bfcount = 0;
            for(int i=1;i<=50;i++)
            {
                if(i%3==0)
                {
                    Console.WriteLine("buzz");
                    bcount++;
                }
                else if(i%5==0)
                {
                    Console.WriteLine("fizz");
                    fcount++;
                }
                else if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("buzzfizz");
                    bfcount++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("buzz count= "+bcount+" fizz count= "+fcount+" buzzfizz count = "+bfcount);
        }
    }
}
