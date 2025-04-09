using System;

// Create an abstract class called Person
public abstract class Person
{
    // Define two properties: firstName and lastName
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Declare an abstract method SayName(). This method must be implemented by any class that inherits from Person.
    public abstract void SayName();
}

// Create a class called Employee that inherits from Person
public class Employee : Person
{
    // Implement the SayName method inside the Employee class
    public override void SayName()
    {
        // Print the full name (FirstName + LastName) of the employee to the console
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate an Employee object with firstName "Sample" and lastName "Student"
        Employee employee = new Employee()
        {
            FirstName = "Sample",
            LastName = "Student"
        };

        // Call the SayName method on the employee object, which will print the name
        employee.SayName();
    }
}