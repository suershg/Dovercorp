using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Number
    {
        private int num1;

        public void SetNumber(int k)
        {
            this.num1 = k;
        }
        public void GetNumber()
        {
            Console.WriteLine(this.num1);
        }
    }

    class  Person
    {
        private string name, gender;
        private int age;
        public void SetDetails(String name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        public void GetDetails()
        {
            Console.WriteLine($"name = {name}, gender = {gender}, age = {age}");
        }
    }
    class Customer
    {
        private string cname, email, ph_num;
        private int id;

        public void SetDetails(string cname, string email, string ph_num, int id)
        {
            this.cname = cname;
            this.email = email;
            this.ph_num = ph_num;
            this.id = id;
        }
        public void GetDetails()
        {
            Console.WriteLine($"cname = {this.cname}, email = {this.email}, id = {this.id}, phone_num = {this.ph_num}");
        }
    }
    class Program20
    {
        static void Main(string[] args)
        {
            /* Number n1 = new Number();
             n1.SetNumber(102);
             n1.GetNumber();*/

            /*  Person p1 = new Person();
              Person p2 = new Person();
              p1.SetDetails("suresh", "male", 25);
              p2.SetDetails("satish", "male", 26);

              p1.GetDetails();
              p2.GetDetails();*/

            Customer c1 = new Customer();
            c1.SetDetails("name", "email@gmail.com", "9848022338", 2345);
            c1.GetDetails();


        }
    }
}
;/*
Class: It is a user defined data type
Object:    Instance of a class
Date member: Refers to variable inside a class
Member function: Refers to function inside a class
private:    Access modifier restrict access of member to outside
public:        Acess modifier allow access of member to outside
 */