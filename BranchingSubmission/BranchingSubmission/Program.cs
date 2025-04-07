using System;


namespace Branching_Submission
{
    class Program
    {
        static void Main()
        {
            double pkgWeight;
            double pkgWidth;
            double pkgLength;
            double pkgHeight;
            double total;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of the package.");
            pkgWeight = Convert.ToDouble(Console.ReadLine());

            //Continue getting input if the package weight is less than 50lbs otherwise end
            if (pkgWeight < 50)
            {
                Console.WriteLine("Please enter the package width.");
                pkgWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height.");
                pkgHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length.");
                pkgLength = Convert.ToDouble(Console.ReadLine());

                //Check the total dimensions are not greater than 50 before calculating total,
                //otherwise display error message and end
                if ((pkgWidth + pkgLength + pkgHeight) < 50)
                {
                    total = (((pkgWidth * pkgHeight * pkgLength) * pkgWeight) / 100.0);
                    Console.WriteLine("Your estimated total for shipping this package is: $" +
                        total.ToString("0.00") + "\nThank you!");
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            Console.ReadLine();
        }
    }
}