using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodechefPractise
{
    internal class DuplicatesFromArray
    {
        static void FindDuplicates(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("Duplicates from array are :");

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    Console.WriteLine(array[i]);
                    // Skip subsequent duplicates
                    while (i < array.Length && array[i] == array[i - 1])
                    {
                        i++;
                    }
                }
            }
        }
        static void Main()
        {
            int[] array = { 12, 32, 564, 342, 763, 8, 5, 753, 2, 6, 8, 32, 8, 342, 8, 2, 753 };
            FindDuplicates(array);
            Console.ReadLine();
        }

    }
}
