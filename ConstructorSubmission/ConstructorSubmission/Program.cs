using System;

namespace ConstructorChainingExample
{
    
    class Person
    {
        public string Name;
        public int Age;

       
        public Person(string name) : this(name, 30) // Chaining to another constructor with a default age of 30
        {
           
        }

        // Constructor that takes both name and age
        public Person(string name, int age)
        {
            Name = name; // Assign name to the Name field
            Age = age;   // Assign age to the Age field
        }

        // Method to display the person's info
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        // const variable 
        const string GREETING = "Welcome to the Person App!";

        static void Main(string[] args)
        {
            // Display a greeting message using the const variable
            Console.WriteLine(GREETING);

            // Use the 'var' keyword to implicitly type a string variable
            var userName = "Alice"; // Compiler infers that userName is of type string

            // Create a Person object using the constructor that takes only a name
            Person person1 = new Person(userName);

            
            person1.DisplayInfo();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}