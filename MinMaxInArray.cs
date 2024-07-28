using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodechefPractise
{
    internal class MinMaxInArray
    {
        static void findMinMax()
        {
            int[] numbers = { 2, 5, -4, 1, 2, 3, 6, 9, 8, 7, 11, 10 };

            //for minimum 
            int min = numbers.Min();
            //for maximum
            int max = numbers.Max();

            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
        }
        static void Main(string[] args)
        {
            MinMaxInArray.findMinMax();
            Console.ReadLine();
        }
    }
}
