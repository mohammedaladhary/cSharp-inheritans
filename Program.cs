namespace Inheritance_exercises
{
    // Define the main program
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Bob", 20, 1234, "Computer Science");
            student.PrintDetails();
            Console.WriteLine("------------------------------------------");

            Dog dog = new Dog("Sony",5,"Havenese","Brr!!");
            //dog.PrintDetails();
            dog.doSomething();
            dog.makeSound();
            Console.WriteLine("------------------------------------------");

            Cat cat = new Cat("Paul", 12);
            cat.doSomething();
            cat.makeSound();
            Console.WriteLine("------------------------------------------");

            //Lion lion = new Lion("Jack", 34);
            //lion.doSomething();
            //lion.makeSound();
        }
    }

}