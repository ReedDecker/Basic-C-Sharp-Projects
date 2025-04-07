using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // One-dimensional array of strings
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // One-dimensional array of integers
        int[] intArray = { 10, 20, 30, 40, 50 };

        // List of strings
        List<string> stringList = new List<string> { "Lion", "Tiger", "Elephant", "Giraffe", "Zebra" };

        // Ask the user to select an index in the string array
        Console.WriteLine("Select an index (0-4) from the string array: ");
        int stringIndex = GetValidIndex(stringArray.Length);
        Console.WriteLine($"You selected: {stringArray[stringIndex]}");

        // Ask the user to select an index in the integer array
        Console.WriteLine("Select an index (0-4) from the integer array: ");
        int intIndex = GetValidIndex(intArray.Length);
        Console.WriteLine($"You selected: {intArray[intIndex]}");

        // Ask the user to select an index in the list of strings
        Console.WriteLine("Select an index (0-4) from the list of strings: ");
        int listIndex = GetValidIndex(stringList.Count);
        Console.WriteLine($"You selected: {stringList[listIndex]}");

        // Wait for user to close the application
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    // Method to get a valid index from the user
    static int GetValidIndex(int length)
    {
        int index = -1;

        // Keep prompting the user until a valid index is entered
        while (index < 0 || index >= length)
        {
            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out index);

            if (!isValid || index < 0 || index >= length)
            {
                Console.WriteLine("Invalid index! Please select a valid index.");
            }
        }

        return index;
    }
}  
