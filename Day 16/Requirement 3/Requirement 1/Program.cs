using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Song> songs = new List<Song>();
            Console.WriteLine("Enter the song 1 details");
                string[]s1 = Console.ReadLine().Split(',');
             Song a = new Song(s1[0], s1[1],s1[2],double.Parse(s1[3]),int.Parse(s1[4]),DateTime.ParseExact(s1[5],"dd-mm-yyy",null));
            songs.Add(a);
            Console.WriteLine("Enter the song 2 details");
            //string c=Console.ReadLine();       other method
            //string[] x = c.Split(',');
            string[] s2 = Console.ReadLine().Split(',');
            Song b = new Song(s2[0], s2[1], s2[2], double.Parse(s2[3]), int.Parse(s2[4]), DateTime.ParseExact(s2[5], "dd-mm-yyy", null));
            songs.Add(b);
            Console.WriteLine("Song 1:\n" + s1);
            Console.WriteLine("Song 2:\n" + s2);
            if (songs[0].Equals(songs[1]))
            {
                Console.WriteLine("Song 1 is same as Song 2");
                
            }
            else
            {
                Console.WriteLine("Song 1 is not same as Song 2");
            }
        }

    }
}
    

