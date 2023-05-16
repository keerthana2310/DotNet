using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);
            //Console.WriteLine("using foreach\n");
            //foreach (int i in li)
            //{
            //    Console.Write(i+""+"\t");
            //}
            //Console.WriteLine("\n"+"using forloop");
            //for(int i=0;i<li.Count;i++)
            //{
            //    Console.Write(li[i]+""+"\t");
            //}
           
           // li.Insert(1, 25);
            li.RemoveAt(1);
            foreach (int i in li)
            {
                Console.Write(i + "" + "\t");
            }
            Console.ReadLine();
        }
    }
}
