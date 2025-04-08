using System;

// The entry point of the application
class Program
{
    static void Main(string[] args)
    {
        // Ask the user to enter a number to perform operations on
        Console.WriteLine("Enter a number to perform math operations on:");

        // Read the user input and convert it to an integer
        int userInput = int.Parse(Console.ReadLine());

        // Create an instance of the MathOperations class to use its methods
        MathOperations mathOps = new MathOperations();

        // Call AddTen method and store the result
        int resultAdd = mathOps.AddTen(userInput);
        // Display the result of adding 10
        Console.WriteLine($"Add 10 to {userInput}: {resultAdd}");

        // Call MultiplyByFive method and store the result
        int resultMultiply = mathOps.MultiplyByFive(userInput);
        // Display the result of multiplying by 5
        Console.WriteLine($"Multiply {userInput} by 5: {resultMultiply}");

        // Call SubtractThree method and store the result
        int resultSubtract = mathOps.SubtractThree(userInput);
        // Display the result of subtracting 3
        Console.WriteLine($"Subtract 3 from {userInput}: {resultSubtract}");
    }
}