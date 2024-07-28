using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodechefPractise
{
    internal class DuplicatesFromCollection
    {
        public static void CollectionDuplicate()
        {
            List<string> names = new List<string>
        {
            "Mia", "Jiya", "Sham", "Jisha", "Jiya", "Siya", "Sham"
        };

            FindingDuplicates(names);
        }

        public static void FindingDuplicates(List<string> names)
        {
            var duplicates = names
                .GroupBy(name => name)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key);

            Console.WriteLine("Duplicate names are:");
            foreach (var name in duplicates)
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            DuplicatesFromCollection.CollectionDuplicate();
            Console.ReadLine();
        }
    }
}
