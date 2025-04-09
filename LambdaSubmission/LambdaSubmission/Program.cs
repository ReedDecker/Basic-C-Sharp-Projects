using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeApp
{
    // Define Employee class
    public class Employee
    {
        // Properties Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize Employee object
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Joe", "Smith"),
                new Employee(2, "Anna", "Johnson"),
                new Employee(3, "Joe", "Williams"),
                new Employee(4, "Megan", "Brown"),
                new Employee(5, "Mike", "Davis"),
                new Employee(6, "Sarah", "Miller"),
                new Employee(7, "Joe", "Taylor"),
                new Employee(8, "David", "Anderson"),
                new Employee(9, "Lucy", "Thomas"),
                new Employee(10, "Robert", "Jackson")
            };

            // Find all employees with the first name "Joe" with foreach loop
            List<Employee> joeEmployees = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joeEmployees.Add(employee);
                }
            }

            // Print the employees with the first name "Joe"
            Console.WriteLine("Employees with the first name 'Joe' (using foreach loop):");
            foreach (var employee in joeEmployees)
            {
                Console.WriteLine($"{employee.Id}: {employee.FirstName} {employee.LastName}");
            }

            // Use a lambda expression to find all employees with the first name "Joe"
            var joeEmployeesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Print the employees with the first name "Joe" using lambda expression
            Console.WriteLine("\nEmployees with the first name 'Joe' (using lambda expression):");
            foreach (var employee in joeEmployeesLambda)
            {
                Console.WriteLine($"{employee.Id}: {employee.FirstName} {employee.LastName}");
            }

            // Use a lambda expression to find all employees with an Id greater than 5
            var employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

            // Print the employees with an Id greater than 5
            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (var employee in employeesWithIdGreaterThan5)
            {
                Console.WriteLine($"{employee.Id}: {employee.FirstName} {employee.LastName}");
            }
        }
    }
}
