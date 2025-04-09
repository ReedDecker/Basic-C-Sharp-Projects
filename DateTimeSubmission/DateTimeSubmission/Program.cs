using System;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            Console.WriteLine("Current date and time: " + DateTime.Now);

            // Ask the user for a number of hours to add
            Console.Write("Enter a number of hours to add: ");
            string input = Console.ReadLine(); // Read user input as a string

            // Try to parse the input string to an integer
            bool isValidNumber = int.TryParse(input, out int hoursToAdd);

            if (isValidNumber)
            {
                // Add the given number of hours to the current time
                DateTime futureTime = DateTime.Now.AddHours(hoursToAdd);

                // Display the result to the console
                Console.WriteLine($"In {hoursToAdd} hours, it will be: {futureTime}");
            }
            else
            {
                // If input is not a valid number, show an error message
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Keep the console window open until the user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}