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
            dog.printSomething();
            Console.WriteLine("------------------------------------------");

            Cat cat = new Cat("Paul", 12);
            cat.doSomething();
            cat.makeSound();
            Console.WriteLine("------------------------------------------");
            //cat.printSomething();
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

            Animal a = new Dog("Sony", 5, "Havenese", "Brr!!");
            a.doSomething();

            // with static, we write static in the function (addInteger)
            Console.WriteLine(addInteger(2, 3));
            //you can access more than one use depends
            //on the number of the function with same name
            //addInteger(2,3); 
            //addInteger(2, 3, 4);
            //addInteger(2.2, 53.5);

            //without static need to do the following:
            // 1. Create an instance of the program class
            Program p = new Program();

            // 2. Call the non-static function using the dot operator
            Console.WriteLine(p.addDouble(2.34, 7.54));


        }

        static int addInteger (int a, int b) //overloading - same name with differnet parameters
        {
            return a + b; // does not have impact on overloading
        }
        static int addInteger(int a, int b, int c) //overloading - same name with differnet parameters
        {
            return a + b + c; // does not have impact on overloading
        }
        static double addInteger(double a, double b) //overloading - same name with differnet parameters
        {
            return a + b; // does not have impact on overloading
        }

        double addDouble(double a, double b)
        {
            return a + b;
        }

        //public void letsDoSomething (Dog d)
        //{
        //    //functionlity
        //}
        //public void letsDoSomething(Cat c)
        //{
        //    //functionlity
        //}
        //public void letsDoSomething(Dog d)
        //{
        //    //functionlity
        //}
    }

}