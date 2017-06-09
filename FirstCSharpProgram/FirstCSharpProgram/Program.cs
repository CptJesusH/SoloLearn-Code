using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displaying data on the screen.
            Console.WriteLine("Hello world!"); // Why is "Hello World" a thing?

            // Using variable placeholders to create formatted strings:
            int x = 10;
            double y = 20;
            Console.WriteLine("x = {0}; y = {1}", x, y); // Output: x = 10; y = 20

            // User Input
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine(); // Assume Mike
            Console.WriteLine("Hello, {0}.", yourName); // Output: Hello, Mike.

            // Converting User Input to Different Data Types
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine()); // Assume 25
            Console.WriteLine("You are {0} years old.", age); // Output: You are 25 years old.

        }
    }
}
