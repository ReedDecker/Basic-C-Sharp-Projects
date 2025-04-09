using System;


public interface IQuittable
{
    // The Quit method is declared in the interface with a void return type.
    void Quit();
}

// Create an Employee class that implements IQuittable
public class Employee : IQuittable
{
    
    public string Name { get; set; }

    // Constructor to initialize the employee's name when an instance is created
    public Employee(string name)
    {
        Name = name;
    }

    // Implement the Quit() method from the IQuittable interface
    public void Quit()
    {
        // This method is called when the employee quits their job. It prints message to console.
        Console.WriteLine($"{Name} has quit their job.");
    }
}

// Main program class where we will demonstrate polymorphism
public class Program
{
    public static void Main(string[] args)
    {
        
        // The name of the employee is set to "John Doe".
        Employee employee = new Employee("John Doe");

        // Use polymorphism: Create an IQuittable reference variable called 'quitter'
        IQuittable quitter = employee;

        // Call the Quit() method on the 'quitter' object.
        quitter.Quit();
    }
}