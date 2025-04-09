using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects with sample data
        Employee emp1 = new Employee(1, "Robert", "Hansen");  // Employee 1 with ID 1 
        Employee emp2 = new Employee(1, "Charlie", "Chaplin");  // Employee 2 with ID 1 

        // Compare 2 Employee objects using the overloaded '==' operator
        if (emp1 == emp2)
        {
            Console.WriteLine("The employees are the same (based on their ID).");
        }
        else
        {
            Console.WriteLine("The employees are different.");
        }

        // Use the '!=' operator to compare 2 Employee objects
        if (emp1 != emp2)
        {
            Console.WriteLine("The employees are not the same.");
        }
        else
        {
            Console.WriteLine("The employees are the same.");
        }
    }
}