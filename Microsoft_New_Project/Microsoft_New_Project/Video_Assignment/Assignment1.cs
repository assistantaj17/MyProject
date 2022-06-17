using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Video_Assignment
{
    internal class Leap_Year_OR_Not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
        }
    }

    class Divisible_by5and11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ente the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("Divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Not Divisible by 5 and 11");
            }
        }
    }

    class MaxBetween3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three number 1 by 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int temp = 0, max = 0;
            temp = (num1 > num2) ? num1 : num2;
            max = (temp > num3) ? temp : num3;
            Console.WriteLine(max);
        }
    }

    class Vowel_Consonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            char ch = Console.ReadLine()[0];
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }

    class PositiveOrNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }

    class AlphabetDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            char ch = Console.ReadLine()[0];
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("It is Character");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("It is Digit");
            }
            else
            {
                Console.WriteLine("It is Special Character");
            }
        }
    }

    class EVENODD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }

    class BankDenomination
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount");
            int amt = Convert.ToInt32(Console.ReadLine());
            int Rs2000, Rs500, Rs200, Rs100, Rs50, Rs20, Rs10, Rs5, Rs2, Rs1;
            Rs2000 = amt / 2000;
            amt = amt % 2000;
            Rs500 = amt / 500;
            amt = amt % 500;
            Rs200 = amt / 200;
            amt = amt % 200;
            Rs100 = amt / 100;
            amt = amt % 100;
            Rs50 = amt / 50;
            amt = amt % 50;
            Rs20 = amt / 20;
            amt = amt % 20;
            Rs10 = amt / 10;
            amt = amt % 10;
            Rs5 = amt / 5;
            amt = amt % 5;
            Rs2 = amt / 2;
            amt = amt % 2;
            Rs1 = amt / 1;
            Console.WriteLine("2000= " + Rs2000 + " 500= " + Rs500 + " 200= " + Rs200 + " 100= " + Rs100);
            Console.WriteLine("50= " + Rs50 + " 20= " + Rs20 + " 10= " + Rs10);
            Console.WriteLine("5= " + Rs5 + " 2= " + Rs2 + " 1= " + Rs1);
        }
    }

    class GrossSalary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your basic salary");
            double basic = double.Parse(Console.ReadLine());
            double hra, da, total;
            if (basic <= 10000)
            {
                hra = basic * (20.0 / 100.0);
                da = basic * (80.0 / 100.0);
                total = basic + hra + da;
                Console.WriteLine("HRA " + hra);
                Console.WriteLine("DA " + da);
                Console.WriteLine("Total Salary is " + total);
            }
            else if (basic <= 20000)
            {
                hra = (25.0 / 100.0) * basic;
                da = (90.0 / 100.0) * basic;
                total = basic + hra + da;
                Console.WriteLine("Total Salary is " + total);
            }
            else if (basic > 20000)
            {
                hra = (30.0 / 100.0) * basic;
                da = (95.0 / 100.0) * basic;
                total = basic + hra + da;
                Console.WriteLine("Total Salary is " + total);
            }
            else
            {
                Console.WriteLine("Enter proper input");
            }
        }
    }

    class AdditionDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = 0, i = 1, sum = 0;
            while (num > 0)
            {
                int rem = num % 10;
                if (i % 2 != 0)
                {
                    sum = sum + rem;
                }
                num = num / 10;
                i++;
            }
            Console.WriteLine("Addition of First and Third Digit is " + sum);
        }
    }

    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Two Number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Press 1 for Addition / Press 2 for Sub / Press 3 for Mul / Press 4 for Division");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, sub = 0, mul = 0, div = 0;
            switch (num)
            {
                case 1:
                    sum = num1 + num2;
                    Console.WriteLine("Sum= " + sum);
                    break;
                case 2:
                    sub = num1 - num2;
                    Console.WriteLine("Sub= " + sub);
                    break;
                case 3:
                    mul = num1 * num2;
                    Console.WriteLine("Mul= " + mul);
                    break;
                case 4:
                    div = num1 / num2;
                    Console.WriteLine("Div= " + div);
                    break;
                default:
                    Console.WriteLine("Enter proper input");
                    break;
            }
        }
    }

    class DayNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of day");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Enter the Proper Input");
                    break;
            }
        }
    }

    class NumberinWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Enter the Proper Input");
                    break;
            }
        }
    }

    class AreaofAll
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press"+"\n"+" 1 for Area of Circle "+"\n"+" 2 for Area of Square"+"\n"+" 3 for Area of Right Angled Triangle"+"\n"+" 4 for Area of Rectangle"+"\n"+" 5 for Circumfenence of Circle"+"\n"+" 6 for Perimeter of Square");
            int num=int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("Enter the radius");
                    int r = int.Parse(Console.ReadLine());
                    double pi = 3.14;
                    double cir = pi * r * r;
                    Console.WriteLine("Area of Circle is "+cir);
                    break;
                case 2:
                    Console.WriteLine("Enter the side value");
                    int s=int.Parse(Console.ReadLine());
                    int asq = s * s;
                    Console.WriteLine("Area of Square "+asq);
                    break;
                case 3:
                    Console.WriteLine("Enter the base and height of triangle");
                    int b=int.Parse(Console.ReadLine());
                    int h=int.Parse(Console.ReadLine());
                    double atr = (b * h) / 2;
                    Console.WriteLine("Area of Traingle is "+atr);
                    break;
                case 4:
                    Console.WriteLine("Enter the width and height ");
                    int w = int.Parse(Console.ReadLine());
                    int ht =int.Parse(Console.ReadLine());
                    int arct = w * ht;
                    Console.WriteLine("Area of Rectangle is "+arct);
                    break;
                case 5:
                    Console.WriteLine("Enter the radius");
                    int rd=int.Parse(Console.ReadLine());
                    double cc = 2 * 3.14 * rd;
                    Console.WriteLine("Circumference of Circle is "+cc);
                    break;
                case 6:
                    Console.WriteLine("Enter the side");
                    int sd=int.Parse(Console.ReadLine());
                    int ps = 4 * sd;
                    Console.WriteLine("Perimeter of Square is "+ps);
                    break;
                default: Console.WriteLine("Enter the proper input");
                    break;
            }
        }
    }
}