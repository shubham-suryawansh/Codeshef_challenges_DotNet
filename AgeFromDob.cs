using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodechefPractise
{
    internal class AgeFromDob
    {
        public static void FindAge()
        {
            //Taking date as an input from user
            Console.WriteLine("Enter date in dd-mm-yyy (01-01-2024)");

            // storing the date in the array by using String split method 
            string[] dateInp = Console.ReadLine().Split('-');

            //converting string to int
            int day = int.Parse(dateInp[0]);
            int month = int.Parse(dateInp[1]);
            int year = int.Parse(dateInp[2]);
            
            if(IsValidDate(day, month, year))
            {
                Console.WriteLine($"\nDate of Birth- {day}-{month}-{year}.");
                DateTime dob= new DateTime(year,month,day);
                int age = CalAge(dob);

                Console.WriteLine($"\nYou are {age} years old.");
            }

        }
        public static int CalAge(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age=today.Year-dob.Year;
            if (dob.Date > today.AddYears(-age)) { age--; }

            return age;
        }

        private static bool IsValidDate(int day, int month, int year)
        {
            if (month < 1 || month > 12) return false;

            int[] daysInMonth = { 31, DateTime.IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return day > 0 && day <= daysInMonth[month - 1];
        }
        static void Main(string[] args)
        {
            AgeFromDob.FindAge();

            Console.ReadLine();
        }
    }
}
