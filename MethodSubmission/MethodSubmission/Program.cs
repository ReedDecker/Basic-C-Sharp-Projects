using System;

namespace OptionalParameterExample
{
    // Class definition
    class MathOperations
    {
        // Method definition with an optional second parameter (default value is 0)
        public int AddNumbers(int num1, int num2 = 0)
        {
            // Perform the addition operation and return the result
            return num1 + num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class to create an object
            MathOperations mathOperations = new MathOperations();

            // Ask the user for the first number
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine()); // Convert user input to an integer

            // Ask the user for the second number (optional)
            Console.Write("Enter the second number (leave blank for 0): ");
            string secondInput = Console.ReadLine();

            // Check if the second number was provided
            int secondNumber;
            if (string.IsNullOrEmpty(secondInput))
            {
                // If no second number is entered, use 0 as the default
                secondNumber = 0;
            }
            else
            {
                // Convert the second input to an integer if provided
                secondNumber = int.Parse(secondInput);
            }

            // Call the AddNumbers method with both numbers
            int result = mathOperations.AddNumbers(firstNumber, secondNumber);

            // Display the result
            Console.WriteLine($"The result of adding {firstNumber} and {secondNumber} is: {result}");

            // To prevent the console window from closing immediately after execution
            Console.ReadLine();
        }
    }
}