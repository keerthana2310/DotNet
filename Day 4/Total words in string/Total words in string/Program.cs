//Write a program in C# Sharp to count the total number of words in a string.
using System;
using System.Threading;

namespace Total_words_in_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            int word = 1;
            Console.WriteLine("total no. of words in a string");
            string name = Console.ReadLine();

            while (l < name.Length)
            {
                if (name[l] == ' ' || name[l] == '\n')
                {
                    word++;
                }
                l++;
            }
           
        
            Console.WriteLine(word);



        }
    }
}
