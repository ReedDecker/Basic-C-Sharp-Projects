using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: A one-dimensional array of strings (animals).
        string[] animals = new string[] { "Lion", "Tiger", "Elephant", "Giraffe" };

        // Step 2: Ask the user to input some text.
        Console.WriteLine("Please enter some text to append to each animal name:");
        string userInput = Console.ReadLine();

        // Step 3: A loop that iterates through each string in the array and adds the user's text input to the end of each string.
        for (int i = 0; i < animals.Length; i++)
        {
            animals[i] += userInput; // Append the user input to each element in the array.
        }

        // Step 4: Then create a second loop that prints off each string in the array one at a time.
        Console.WriteLine("\nUpdated animal list after appending your input:");
        foreach (string animal in animals)
        {
            Console.WriteLine(animal);
        }

        // Step 5: An infinite loop.
        // The infinite loop is used for demonstration. 
        // Step 7: Fix the infinite loop so that it will execute properly.
        int count = 0;
        while (true)
        {
            count++;
            Console.WriteLine($"Infinite loop iteration: {count}");

            // Step 7: Fix the infinite loop by adding a condition to break after 5 iterations.
            if (count > 5)
            {
                break; // Breaks the infinite loop after 5 iterations.
            }
        }

        // Step 8: The infinite loop was fixed by adding the condition `if (count > 5)` to stop it after 5 iterations.

        // Step 9: A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
        Console.WriteLine("\nLoop where comparison uses < operator:");
        for (int i = 0; i < 5; i++) // This loop runs while i < 5.
        {
            Console.WriteLine(i);
        }

        // Step 10: Save and execute your code (this step involves running the code, which is done in the previous steps).

        // Step 11: A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
        Console.WriteLine("\nLoop where comparison uses <= operator:");
        for (int i = 0; i <= 5; i++) // This loop runs while i <= 5.
        {
            Console.WriteLine(i);
        }

        // Step 12: A list of strings where each item in the list is unique (list of animal types).
        List<string> animalList = new List<string> { "Dog", "Cat", "Elephant", "Tiger", "Lion" };

        // Step 13: Ask the user to input text to search for in the list.
        Console.WriteLine("\nEnter an animal name to search for in the list:");
        string searchAnimal = Console.ReadLine();

        // Step 14: A loop that iterates through the list and displays the index of the list item that contains matching text on the screen.
        bool found = false;
        for (int i = 0; i < animalList.Count; i++)
        {
            if (animalList[i].Contains(searchAnimal))
            {
                Console.WriteLine($"Found matching animal at index {i}: {animalList[i]}");
                found = true;
                break; // Stop the loop once a match is found (Step 16).
            }
        }

        // Step 15: Add code to check if the user put in text that isn't on the list.
        if (!found)
        {
            Console.WriteLine("The animal name you entered was not found in the list.");
        }

        // Step 17: A list of strings that has at least two identical strings in the list.
        List<string> animalListWithDuplicates = new List<string> { "Dog", "Cat", "Dog", "Elephant", "Lion" };

        // Step 18: Create a loop that iterates through the list and displays the indices of the items matching the user-selected text.
        Console.WriteLine("\nEnter an animal name to search for in the list with duplicates:");
        string searchAnimalWithDuplicates = Console.ReadLine();

        bool foundDuplicate = false;
        for (int i = 0; i < animalListWithDuplicates.Count; i++)
        {
            if (animalListWithDuplicates[i] == searchAnimalWithDuplicates)
            {
                Console.WriteLine($"Found matching animal at index {i}: {animalListWithDuplicates[i]}");
                foundDuplicate = true;
            }
        }

        // Step 19: Add code to check if the user put in text that isn't on the list with duplicates.
        if (!foundDuplicate)
        {
            Console.WriteLine("The animal name you entered was not found in the list with duplicates.");
        }

        // Step 20: Create a list of strings that has at least two identical strings in the list.
        List<string> animalListWithDupes = new List<string> { "Elephant", "Lion", "Cat", "Lion" };

        // Step 21: Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
        Console.WriteLine("\nChecking for duplicates in the list:");
        HashSet<string> seenAnimals = new HashSet<string>(); // To track already seen animals.
        foreach (string animal in animalListWithDupes)
        {
            if (seenAnimals.Contains(animal))
            {
                Console.WriteLine($"{animal} - this item is a duplicate");
            }
            else
            {
                Console.WriteLine($"{animal} - this item is unique");
                seenAnimals.Add(animal);
            }
        }

        // End of program
        Console.WriteLine("\nProgram execution finished.");
    }
}
