using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = SongsRepo.GetAllSongs();

            foreach (Song s in songs)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}