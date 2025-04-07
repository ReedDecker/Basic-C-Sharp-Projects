using System;


namespace Boolean_Logic_Submission
{
    class Program
    {
        static void Main()
        {
            int age;
            int tickets;

            bool DUI;
            bool qualified;

            //get input from user
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please type true or false");
            DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            tickets = Convert.ToInt32(Console.ReadLine());

            //determine qualification
            qualified = ((age > 15) && (DUI == false) && (tickets <= 3));
            Console.WriteLine("Qualified? \n" + qualified);
            Console.ReadLine();
        }
    }
}

