using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_3
{
    internal class SongsRepo
    {
        static List<Song> songs = new List<Song>
        {
            new Song("shape of you","Eeshwar","pop",4.8,100,DateTime.Parse("12-8-2010")),
            new Song("devil of tour","Rahul","pop",5.6,80,DateTime.Parse("23-5-2012")),
            new Song("Mercy","Gopi","Jazz",8,95,DateTime.Parse("22-9-2018")),
            new Song("Killer","Ram","pop",8.7,98,DateTime.Parse("28-8-2019"))

         };
        public static List<Song> GetAllSongs()
        {
            return songs;
        }
    }
}
