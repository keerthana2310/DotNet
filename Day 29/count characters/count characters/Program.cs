using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hi @Paru";
            
            int character = 0;
            int vowel = 0;
            int consonant = 0;
            str=str.ToLower();
            for(int i=0;i<str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowel++;
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    consonant++;
                }

                else if (str[i] == '@' || str[i] == '#' || str[1] =='$')
                {
                    character++;
                }
                
            }
            Console.WriteLine("consonants are"+ consonant);
            Console.WriteLine("vowels are"+ vowel);
            Console.WriteLine("character are" + character);

        }
    }
}
