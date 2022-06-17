using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Weekly_Test
{
    internal class Print1To100
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%5!=0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }
    }

    class FactorofNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class EvenOdd1To50
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    int sq = 0;
                    sq = i * i;
                    Console.WriteLine(sq);
                }
            }
        }
    }

    class Fibbon
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, sum = 0,n=0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            while (n < 20)
            {
                sum = a + b;
                a = b;
                b = sum;
                n++;
                Console.WriteLine(sum);
            }
        }
    }

    class HarshadNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("Harshad Number");
            }
            else
            {
                Console.WriteLine("Not Harshad Number");
            }
        }
    }

    class RedBlue
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Red");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Blue");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Order
    {
        private int order_id;
        private string city;
        private string cust_name;
        private bool isDelivered;

        public int Order_id
        {
            get { return order_id; }
            set { order_id = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Cust_name
        {
            get { return cust_name; }
            set { cust_name = value; }
        }
        public bool IsDelivered
        {
            get { return isDelivered; }
            set { isDelivered = value; }
        }
        
    }
    class Prog
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.Order_id = 101;
            o.City = "Pune";
            o.Cust_name = "Vicky";
            o.IsDelivered = true;
            Console.WriteLine(o.Order_id+" "+o.City+" "+o.Cust_name+" "+o.IsDelivered);
        }
    }

    class Krishnamurthy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = 0, sum = 0;
            temp = num;
            while(temp>0)
            {
                int fact = 1;
                int rem = temp % 10;
                for(int i=1;i<=rem;i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                temp = temp / 10;
            }
            if(num==sum)
            {
                Console.WriteLine("Krishnamurthy Number");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy Number");
            }
        }
    }
}
