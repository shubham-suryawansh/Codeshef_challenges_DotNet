using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodechefPractise
{
    internal class DateAndString
    {
        static void ConvertDateString()
        {
            //  Accept date and time input from the user
            Console.Write("Enter the date and time (format: yyyy-MM-dd HH:mm:ss): ");
            string userInput = Console.ReadLine();

            // Define the format of the date string
            string format = "yyyy-MM-dd HH:mm:ss";

            //  Convert the string to DateTime
            DateTime parsedDate;
            if (DateTime.TryParseExact(userInput, format, null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine($"Parsed DateTime: {parsedDate}");

                //  Convert the DateTime back to a string
                string dateString = parsedDate.ToString(format);
                Console.WriteLine($"DateTime as string: {dateString}");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please use yyyy-MM-dd HH:mm:ss.");
            }
        }

        static void Main(string[] args)
        {
            DateAndString.ConvertDateString();
            Console.ReadLine();
        }
    }
}
