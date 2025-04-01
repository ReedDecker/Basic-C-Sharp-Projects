using System;
using System.Web;

namespace DailyReportSubmission
{
    class Program
    {
        static void Main()
        {
            int pageNum;
            int hoursStudied;
            
            bool helpNeeded;
            
            string name;
            string course;
            string experience;
            string feedback;



            Console.WriteLine("The Tech Academy \nStudent Daily Report\n\n");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            course = Console.ReadLine();
            Console.WriteLine("What page number?");
            pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer true or false");
            helpNeeded = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Where there any positive experiences that you would like to share?");
            experience = Console.ReadLine();
            Console.WriteLine("Is there any other feeback that you'd like to provide? Please be specific.");
            feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            hoursStudied = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
