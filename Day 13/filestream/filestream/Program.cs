using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filestream
{
    internal class Program
    {
        static string file = "D:\\C#\\Day 13\\filestream";
        static void Main(string[] args)
        {
           Write();
            Read();
        }
        static void Write()
        {
            StreamWriter fileStream=new StreamWriter(file);
            fileStream.WriteLine("What is this life is");
            fileStream.WriteLine("We have no time to stand");
            fileStream.Close();
        }
        static void Read()
        {
            StreamReader fileStream=new StreamReader(file);
            string s = null;
            while((s=fileStream.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            fileStream.Close();
        

    }
    }
}
