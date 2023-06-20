namespace Inheritance_exercises
{
    // Define the main program
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Bob", 20, 1234, "Computer Science");
            student.PrintDetails();
            Console.WriteLine("---------------------Animal---------------------");

            Dog dog = new Dog("Sony", 5, "Havenese", "Brr!!");
            Dog dog2 = new Dog("Sony", 5, "Havenese", "Brr!!");

            Console.WriteLine(dog.Equals(dog2));//true
            //dog.PrintDetails();
            dog.doSomething();
            dog.makeSound();
            Console.WriteLine("------------------------------------------");

            Cat cat = new Cat("Paul", 12);
            cat.doSomething();
            cat.makeSound();
            Console.WriteLine("------------------------------------------");
            cat.printSomething();
            //Lion lion = new Lion("Jack", 34);
            //lion.doSomething();
            //lion.makeSound();
            Console.WriteLine("------------------circle------------------------");

            Circle circle = new Circle(5);

            // Create a rectangle with length 10 and width 8
            Rectangle rectangle = new Rectangle(10, 8);

            Console.WriteLine("Area of the circle is = " + circle.GetArea());
            Console.WriteLine("Perimeter of the circle is = " + circle.GetPerimeter());
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Area of the rectangle = " + rectangle.GetArea());
            Console.WriteLine("Perimeter of the rectangle is = " + rectangle.GetPerimeter());
        }
    }

}