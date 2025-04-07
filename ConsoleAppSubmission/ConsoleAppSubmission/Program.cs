using System;

namespace ConsoleAppSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please write your Name and Password:");
            bool isUserLoggedIn = false;
            int loginAttempts = 0;

          
            while (!isUserLoggedIn && loginAttempts < 3)
            {
                loginAttempts++;
                Console.WriteLine($"Attempt {loginAttempts}: Please enter your Name and Password or write 'Yes' when prompted to proceed without login credentials.");

             
                Console.WriteLine("Is the login successful? (yes/no):");
                string userResponse = Console.ReadLine().ToLower();

                if (userResponse == "yes")
                {
                    isUserLoggedIn = true;
                    Console.WriteLine("Login successful!");
                }
                else
                {
                    Console.WriteLine("Incorrect credentials. Please try again.");
                }
            }

            if (!isUserLoggedIn)
            {
                Console.WriteLine("You have exceeded the maximum login attempts.");
            }

            
            Console.WriteLine("\nCapital City Quiz:");
            bool isCorrectAnswer = false;

            
            do
            {
                Console.WriteLine("What is the capital of France?");
                Console.WriteLine("1. Berlin");
                Console.WriteLine("2. Madrid");
                Console.WriteLine("3. Paris");
                Console.WriteLine("4. Rome");
                Console.Write("Please enter the correct number: ");

                string userAnswer = Console.ReadLine();

                
                if (userAnswer == "3")
                {
                    isCorrectAnswer = true;
                    Console.WriteLine("Correct! Paris is the capital of France.");
                }
                else
                {
                    Console.WriteLine("Incorrect answer. Please try again.");
                }

            } while (!isCorrectAnswer); 

            Console.WriteLine("Quiz completed!");
        }
    }
}