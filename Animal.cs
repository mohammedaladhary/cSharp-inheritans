using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance_exercises
{
    internal abstract class Animal
    {
        public string Name;
        public int Age;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual void  doSomething()
        {
            Console.WriteLine("Animal - doSomething");
        }
        //public abstract void makeSound();
        public virtual void makeSound()
        {
            Console.WriteLine("Sound of Dog");
        }
        public override bool Equals(object? obj)
        {
            Animal animal = obj as Animal;
            if (animal == null)
            {
                return false;
            }
            return this.Name == ((Animal)obj).Name;
        }
        public virtual void printSomething()
        {
            Console.WriteLine("aAbBcC");
        }
    }

    internal class Dog : Animal
    {
        public string Breed;
        public string Sound;

        public Dog(string name, int age, string breed, string sound) : base(name, age)
        {
            this.Breed = breed;
            this.Sound = sound;
        }
       
        //public void PrintDetails()
        //{
        //    Console.WriteLine("Name: " + Name);
        //    Console.WriteLine("Age: " + Age);
        //    Console.WriteLine("Breed: " + Breed);
        //    Console.WriteLine("Soound: " + Sound);
        //}
        public override void doSomething()
        {
            Console.WriteLine("Dog - doSomething");
        }
        public override void makeSound()
        {
            Console.WriteLine("Sound of Dog");
        }
    }
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void makeSound()
        {
            Console.WriteLine("Sound of cat");
        }
        public new void printSomething()
        {
            Console.WriteLine("abc");
        }
    }
    sealed class Lion : Animal
    {
        public Lion(string name, int age) : base(name, age)
        {
        }
        public override void makeSound()
        {
            Console.WriteLine("Sound of lion");
        }
    }
    //internal class example : Lion
    //{
    //    //cannot derive from sealed type "Lion"
    //}
}
