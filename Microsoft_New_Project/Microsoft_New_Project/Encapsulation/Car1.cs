using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.Encapsulation
{
	class Car1
	{
		private string modelno;
		private string name, colour;
		private int prize;

		public string Modelno
		{
			get { return modelno; }
			set { modelno = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Colour
		{
			get { return colour; }
			set { colour = value; }
		}
		public int Prize
		{
			get { return prize; }
			set { prize = value; }
		}
	}


	class Property1
	{
		static void Main(string[] args)
		{
			Car1 c = new Car1();
			c.Modelno = "L928";
			c.Name = "Nexon";
			c.Colour = "Silver";
			c.Prize = 9023412;

			Console.WriteLine(c.Modelno + " " + c.Name + " " + c.Colour + " " + c.Prize);
		}
	}	

	class Student
    {
		private int student_id;
		private string name;
		private double per;
		private bool isPlace;
		public int Student_id
        {
            get { return student_id; }
            set { student_id = value; }
        }
		public string Name
        {
			get;
			set;
        }
		public double Per
        {
            get { return per; }
            set { per = value; }
        }
		public bool IsPlace
        {
            get { return isPlace; }
            set { isPlace = value; }
        }
        static void Main(string[] args)
        {
			Student s = new Student();
			s.Student_id = 101;
			s.Name = "Abhishek";
			s.Per = 86.25;
			s.IsPlace = true;
            Console.WriteLine(s.Student_id+" "+s.Name+" "+s.per+" "+s.isPlace);
        }
    }

	class Employee
    {
		private int id;
		private string name;
		private int salary;
		public Employee(int id,string name,int salary)
        {
			this.id = id;
			this.name = name;
			this.salary = salary;
        }
		public void show()
        {
            Console.WriteLine(id+" "+name+" "+salary);
        }
    }
	class EmployeeInfo
    {
        static void Main(string[] args)
        {
			Employee e = new Employee(101, "Ganesh", 56200);
			e.show();
        }
    }

	class Address
    {
		private int pincode;
		private string city;
		public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
		public string City
        {
            get { return city; }
            set { city = value; }
        }
		public void show()
        {
            Console.WriteLine(pincode+" "+city);
        }
    }
	class Person
    {
		private int id;
		private string name;
		
		public int Id
		{
			get {  return id; }
            set { id = value; }
		}
		public string Name
        {
            get { return name; }
            set { name = value; }
        }
		public void show()
        {
            Console.WriteLine(id+" "+name);
        }
		static void Main(string[] args)
		{
			Address adr = new Address();
			adr.Pincode = 443521;
			adr.City = "Nashik";
			Person p = new Person();
			p.id = 305;
			p.name = "Pandu";
			adr.show();
			p.show();
		}   
	}
}
