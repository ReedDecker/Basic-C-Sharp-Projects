using System;

namespace MathOperationsApp
{
    // Create a class named MathOperations
    class MathOperations
    {
        // Method 1: Takes an integer, performs an addition operation, and returns an integer.
        public int PerformOperation(int number)
        {
            // Add 10 to the number and return the result.
            return number + 10;
        }

        // Method 2: Takes a decimal, performs a subtraction operation, and returns an integer.
        public int PerformOperation(decimal number)
        {
            // Subtract 5 from the decimal and cast it to an integer before returning the result.
            return (int)(number - 5);
        }

        // Method 3: Takes a string, converts it to an integer, performs a multiplication operation, and returns an integer.
        public int PerformOperation(string number)
        {
            // Try to convert the string to an integer, if successful, perform the operation.
            if (int.TryParse(number, out int parsedNumber))
            {
                // Multiply the parsed number by 3 and return the result.
                return parsedNumber * 3;
            }
            else
            {
                // If the string cannot be converted to an integer, return 0.
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class.
            MathOperations mathOperations = new MathOperations();

            // Call the first method with an integer parameter and display the result.
            int result1 = mathOperations.PerformOperation(15); // Passing 15 as integer
            Console.WriteLine($"Result of integer operation: {result1}");

            // Call the second method with a decimal parameter and display the result.
            int result2 = mathOperations.PerformOperation(20.75m); // Passing 20.75 as decimal
            Console.WriteLine($"Result of decimal operation: {result2}");

            // Call the third method with a string parameter and display the result.
            int result3 = mathOperations.PerformOperation("7"); // Passing "7" as string
            Console.WriteLine($"Result of string operation: {result3}");

            // To keep the console window open until a key is pressed.
            Console.ReadKey();
        }
    }
}