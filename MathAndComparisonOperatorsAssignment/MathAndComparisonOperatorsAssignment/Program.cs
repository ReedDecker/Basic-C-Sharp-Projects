using System;


namespace MathAndComparisonOperatorsSubmission
{
    class Program
    {
        static void Main()
        {
            double hourlyRate1;
            double hoursPerWeek1;
            double hourlyRate2;
            double hoursPerWeek2;
            double salaryPerson1;
            double salaryPerson2;
            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
            hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hourly Per Week: ");
            hoursPerWeek1 = Convert.ToDouble(Console.ReadLine());

            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hourly Per Week: ");
            hoursPerWeek2 = Convert.ToDouble(Console.ReadLine());

            //calculate totals
            salaryPerson1 = hourlyRate1 * hoursPerWeek1 * 52;
            salaryPerson2 = hourlyRate2 * hoursPerWeek2 * 52;

            //display Person 1
            Console.WriteLine("Annual salary of Person 1: " + salaryPerson1);

            //display Person2
            Console.WriteLine("Annual salary of Person 2: " + salaryPerson2);

            //Display boolean comparison
            Console.WriteLine("Does Person 1 make more money than Person 2? " + (salaryPerson1 > salaryPerson2));

            Console.ReadLine();
        }
    }
}