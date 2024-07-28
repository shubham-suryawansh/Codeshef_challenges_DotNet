using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find numbers vowels from given string 

namespace CodechefPractise
{
    internal class CountVowels
    {
        string str;

        public void StrVowels()
        {
            int count = 0;
            Console.WriteLine("Enter a word:");
            str= Console.ReadLine();

            for(int i = 0;i< str.Length;i++)
            {
                if (str[i] == 'a' || str[i] == 'A' || str[i] == 'e' || str[i] == 'E' || str[i] == 'i' || str[i] == 'I' || str[i] == 'o' || str[i] == 'O' || str[i] == 'u' || str[i] == 'U')
                {
                    count++;
                }

            }
            Console.WriteLine($"{str} have {count} vowels.");
        }
        static void Main(string[] args)
        {
            CountVowels vowels = new CountVowels();
            vowels.StrVowels();

            Console.ReadKey();  
        }
    }
}
