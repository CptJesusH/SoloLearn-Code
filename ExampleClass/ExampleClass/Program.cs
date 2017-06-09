using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This code explains how a class is declared, how access modifiers can protect fields and methods within the class,
/// and how Constructor Methods can be used to access private fields within the class. 
/// </summary>

namespace ExampleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p0 = new Person("Mike");
            // Instantiate a new Person object called p1, pass "Mike" through to the constructor method
            p0.SayHi(); // Outputs "Hi"
            // Call the SayHi() method contained within the p1 object
            // If SayHi() was set to private, I would not be able to call it with .
            Console.WriteLine(p0.getName()+" < that was written by the getName method within Person");

            Person p1 = new Person();
            p1.Name = "Bob";
            Console.WriteLine(p1.Name);

            Person2 p21 = new Person2();
            p21.Name = "Bobfred";
            Console.WriteLine(p21.Name + " < Name property in Person2 created by { get; set; } auto-property");
        }
    }

    /// <summary>
    /// The below code is my custom class called Person. It contains two private fields: age and name, a constructor method
    /// that is automatically called when a new Person object is instantiated, a public method that reads and returns
    /// the private name field when called, and a public method that greets the user when called. 
    /// </summary>

    class Person
    // Declare a class named Person which has age and name fields and a method called SayHi()
    {
        private int age = 25;
        private string name = "Mike";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person()
        // Constructor that takes no arguements
        {

        }
        public Person(string nm)
        // Constructor that takes one string type arguement
        {
            Console.WriteLine("This was written by the constructor method within the Person class");
            name = nm;
        }

        public string getName()
        // Method for reading and returning the value of private field name
        {
            return name;
        }
        
        public void SayHi()
        // public specifies that other classes can access this method (member)
        // This method also does not return a value, hence void
        {
            Console.WriteLine("Hi! My name is {0}, and I am {1} years old.", name, age);
        }
    }

    class Person2
    // Class created for auto-property example
    {
        public string Name { get; set; }
        // This auto-property automatically creates a private field called Name and allows other classes to read
        // and write values to it. Auto-properties are a more elegant way of defining fields within a class.
    }
}
