using System;

public class Employee
{
   
    public int Id { get; set; }  // Unique ID of Employee
    public string FirstName { get; set; }  // First Name Employee
    public string LastName { get; set; }  // Last Name of Employee

    // Constructor to initialize Employee object
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    // Overload the '==' operator to compare two Employee objects by their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both objects are null or if one is null and the other isn't
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
        {
            return true;  // Both are null, so they are considered equal
        }
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
        {
            return false;  // One is null and the other is not, so they are not equal
        }

       
        return emp1.Id == emp2.Id;
    }

    // Overload the '!=' operator as it must be overloaded in pairs with '=='
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);  // Return the opposite of the '==' comparison
    }

    // Override the Equals method to ensure it works correctly with '=='
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;  // If the object is null or of a different type, they are not equal
        }
        Employee other = (Employee)obj;
        return this.Id == other.Id;  // Compare the Id properties
    }

    // Override GetHashCode to maintain consistency with Equals
    public override int GetHashCode()
    {
        return Id.GetHashCode();  // Use the Id property for generating the hash code
    }
}