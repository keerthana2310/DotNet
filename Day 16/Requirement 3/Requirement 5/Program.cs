using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            Console.WriteLine("Enter the no.of songs");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                //double r = double.Parse(s[3]);
                //int nd = int.Parse(s[4]);
                //DateTime dt = DateTime.Parse(s[5]);
                
                Song s1 = new Song(s[0], s[1],s[2], DateTime.Parse(s[3]), double.Parse(s[4]),int.Parse(s[5]));
                list.Add(s1);
            }

            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
            sd = Song.CalculateTypeCount(list);
            Console.WriteLine("Songtype \t count");
            foreach(var item in sd)
            {
                Console.WriteLine(item.Key+"\t\t"+item.Value);
            }


        }

    }
}
