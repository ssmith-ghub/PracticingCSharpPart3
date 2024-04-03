using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;  //declaration
            x = 123; //initialization

            int y = 321;  //declaration and initialization

            int z = x + y;

            int age = 21; //int only stores a whole number
            double height = 300.5; // decimal number
            bool alive = true; // can only be true or false
            char symbol = '@'; // must use single '' quotes can only store a single character
            string name = "Stephen"; // must use double "" quotes and can store multiple characters
            string userName = symbol + name; //example of combining other variables into a new variable.

            Console.WriteLine(x);
            Console.ReadKey();
            Console.WriteLine(y);
            Console.ReadKey();
            Console.WriteLine(z);
            Console.ReadKey();
            Console.WriteLine(x + y);
            Console.ReadKey();
            Console.WriteLine("This is me learning variabless\b\nAlso using previous concepts");
            Console.WriteLine("Dringking age is " + age);
            Console.WriteLine("The average height of people is " + height + "cm");
            Console.WriteLine("Am I alive? " + alive);
            Console.WriteLine("My email is ssmith_138823" + symbol + "outlook.com");
            Console.WriteLine("My name is " + name);
            Console.WriteLine("My user name is " + userName);

        }
    }
}
