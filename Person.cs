using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance_exercises
{
    internal class Person
    {
        public string name;
        public int age;
        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }
    }
    internal class Student : Person
    {
        public int studentID;
        public string major;

        public Student(string name, int age, int studentID, string major) : base(name, age)
        {
            this.studentID = studentID;
            this.major = major;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Student ID: " + studentID);
            Console.WriteLine("Major: " + major);
        }

    }
}
