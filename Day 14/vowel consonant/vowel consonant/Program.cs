using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel_consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the line");
            string s = Console.ReadLine();
           int vowels = 0;
            int consonants = 0;
            int digits = 0;
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == 'A' || s[i] == 'a' || s[i] == 'E' || s[i] == 'e' ||
                    s[i] == 'I' || s[i] == 'i' || s[i] == 'O' || s[i] == 'o' ||
                    s[i] == 'U' || s[i] == 'u')
                { vowels++; }
                else if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    consonants++;
                }
                else
                {
                   bool p=(s[i] >= '0' && s[i] <= '9');
                        
                    digits++;
                }

            }
            Console.WriteLine("count of vowel" + vowels);
            Console.WriteLine("count of consonant" + consonants);
            Console.WriteLine("count of digit" + digits);


        }
    }
}
