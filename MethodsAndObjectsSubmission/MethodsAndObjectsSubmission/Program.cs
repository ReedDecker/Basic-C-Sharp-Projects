using System;

// Define the Person class with two properties, FirstName and LastName.
public class Person
{
    // Property to hold the first name of the person.
    public string FirstName { get; set; }

    // Property to hold the last name of the person.
    public string LastName { get; set; }

    // Method to print the full name of the person in the format "Name: [full name]".
    public void SayName()
    {
        // Print the full name to the console.
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

// Define the Employee class that inherits from the Person class.
public class Employee : Person
{
    // Property to hold the employee ID, which is an integer.
    public int Id { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Employee object, initializing the FirstName and LastName properties.
        Employee employee = new Employee
        {
            FirstName = "Sample",   // Assign the first name "Sample".
            LastName = "Student"    // Assign the last name "Student".
        };

        // Call the SayName method from the Person class, which will print the employee's full name.
        employee.SayName();

        // The console will display: "Name: Sample Student"
    }
}