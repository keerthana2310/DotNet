using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the string");
            //string s=Console.ReadLine();
            //for( int i=0;i<s.Length;i++)
            //{
            string sentence = "How are you";
            sentence=Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
           Console.WriteLine( wordCount);

        }
    }
}
