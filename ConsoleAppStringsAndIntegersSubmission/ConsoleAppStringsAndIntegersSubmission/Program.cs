using System;

class Program
{
    static void Main()
    {
        // Create a list of integers
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Ask the user for a number to divide each number in the list by
        Console.Write("Enter a number to divide each number in the list by: ");

        // Initialize the user input variable
        string userInput = Console.ReadLine();

        // Attempt to parse the user input as an integer
        try
        {
            // Convert user input to an integer
            int divisor = int.Parse(userInput);

            // Loop through each number in the array and perform division
            foreach (int number in numbers)
            {
                // Divide the number by the divisor and display the result
                Console.WriteLine($"{number} ÷ {divisor} = {number / divisor}");
            }
        }
        // Catch any division by zero errors
        catch (DivideByZeroException ex)
        {
            // Display an error message if the user tries to divide by zero
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        // Catch any errors related to invalid input (non-numeric strings)
        catch (FormatException ex)
        {
            // Display an error message if the user enters a non-numeric value
            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
        }
        // Catch any other unforeseen errors
        catch (Exception ex)
        {
            // Display a general error message for unexpected errors
            Console.WriteLine($"Error: {ex.Message}");
        }

        // Code below the try/catch block to show that the program continues execution after the error handling
        Console.WriteLine("\nThe program has continued after the try/catch block.");
    }
}