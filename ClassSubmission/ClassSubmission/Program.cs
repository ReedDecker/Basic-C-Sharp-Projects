using System;

namespace MethodExample
{
    // Declare a static class. Static classes cannot be instantiated.
    public static class MathOperations
    {
        // Create a method that divides the passed integer by 2.
        public static void DivideByTwo(int number)
        {
            // Output the result of dividing the number by 2.
            Console.WriteLine("The number divided by 2 is: " + (number / 2));
        }

        // Overloaded method with a different parameter type (double instead of int).
        // This method also divides the number by 2 but works for decimal values.
        public static void DivideByTwo(double number)
        {
            // Output the result of dividing the number by 2.
            Console.WriteLine("The number divided by 2 is: " + (number / 2));
        }

        // Method with output parameters. It divides the number by 2 and returns the result via the output parameter.
        public static void DivideByTwoWithOutput(int number, out int result)
        {
            // Perform division and set the result to the output parameter.
            result = number / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for a number.
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call the method DivideByTwo with the integer parameter.
            MathOperations.DivideByTwo(userInput);

            // Call the overloaded method DivideByTwo with a double parameter.
            MathOperations.DivideByTwo((double)userInput);

            // Declare an integer variable to hold the result for the output parameter.
            int result;

            // Call the method with an output parameter.
            MathOperations.DivideByTwoWithOutput(userInput, out result);

            // Display the result returned via the output parameter.
            Console.WriteLine("The result using the output parameter is: " + result);

            // Keep the console window open until the user presses a key.
            Console.ReadKey();
        }
    }
}