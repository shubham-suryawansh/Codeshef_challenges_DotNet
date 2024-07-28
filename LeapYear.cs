using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodechefPractise
{
    internal class LeapYear
    {
        public static void CheckLeap()
        {
            //Taking date as an input from user
            Console.WriteLine("Enter date in dd-mm-yyy (01-01-2024)");

           // storing the date in the array by using String split method 
            string[] dateInp = Console.ReadLine().Split('-');
            
            //converting string to int
            int day= int.Parse(dateInp[0]);
            int month = int.Parse(dateInp[1]);
            int year = int.Parse(dateInp[2]);

            if(IsValidDate(day,month,year))
            {
                Console.WriteLine($"Date Entered- {day}-{month}-{year}");
            
                //checking for leap year using IsLeapYear function of DateTime 
                Console.WriteLine($"\nChecking for Leap year for year {year}...\n");
                if(DateTime.IsLeapYear(year))
                {
                    Console.WriteLine($"{year} is a Leap Year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a  Leap Year.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Date Format. Please enter the date as given.");
            }
        }
        private static bool IsValidDate(int day, int month, int year)
        {
            if (month < 1 || month > 12) return false;

            int[] daysInMonth = { 31, DateTime.IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return day > 0 && day <= daysInMonth[month - 1];
        }
        static void Main(string[] args)
        {
            LeapYear.CheckLeap();
            Console.ReadLine();
        }
    }
    
}




