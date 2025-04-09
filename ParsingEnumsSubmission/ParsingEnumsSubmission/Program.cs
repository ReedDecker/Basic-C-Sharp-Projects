using System;

namespace WeekDayEnumExample
{
    // Enum for the days of the week.
    enum DayOfWeekEnum
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter the current day of the week.
            Console.WriteLine("Please enter the current day of the week (e.g., Monday):");

            // Read user input and try to parse it into the enum type.
            string inputDay = Console.ReadLine();

            // Declare a variable to store the value of the parsed day of the week.
            DayOfWeekEnum currentDay;

            // Try parsing the user input into the enum, using a try/catch block to handle errors.
            try
            {
                // Try to parse the input to the enum DayOfWeekEnum.
                currentDay = (DayOfWeekEnum)Enum.Parse(typeof(DayOfWeekEnum), inputDay, true);

                // If successful, print the parsed value to the console.
                Console.WriteLine("The day you entered is: " + currentDay);
            }
            catch (ArgumentException)
            {
                // If the parsing fails (i.e., the input is not a valid day), catch the error and print a user-friendly message.
                Console.WriteLine("Please enter an actual day of the week.");
            }

            
        }
    }
}