using System;
using System.Text;

class Program
{
    static void Main()
    {
      
        string str1 = "Goodbye";
        string str2 = "Earthlings";
        string str3 = "!";
        string concatenatedString = str1 + " " + str2 + str3;
        Console.WriteLine("Concatenated String: " + concatenatedString);

     
        string originalString = "This isn't my library voice.";
        string upperCaseString = originalString.ToUpper();
        Console.WriteLine("Uppercase String: " + upperCaseString);

       
        StringBuilder paragraph = new StringBuilder();
        paragraph.AppendLine("This is the first sentence.");
        paragraph.AppendLine("This is the second sentence.");
        paragraph.AppendLine("This is the third sentence.");
        paragraph.AppendLine("This is the fourth sentence.");

        Console.WriteLine("\nParagraph: ");
        Console.WriteLine(paragraph.ToString());

        
        Console.ReadKey();
    }
}
