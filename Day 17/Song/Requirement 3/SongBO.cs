using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_3
{
    internal class SongBO
    {
        public List<Song> FindSong(List<Song> song, string type)

        {

            List<Song> list = new List<Song>();

            foreach (var items in song)

            {

                if (items.SongType == type)

                {

                    list.Add(items);

                }

            }

            return list;

        }

        public List<Song> FindSong(List<Song> SongList, double rating)

        {

            List<Song> li = new List<Song>();

            foreach (var item in SongList)

            {

                if (item.Rating == rating)

                {

                    li.Add(item);

                }

            }

            return li;

        }

        public List<Song> FindSong(List<Song> SongList, DateTime dateCreated)

        {

            List<Song> li = new List<Song>();

            foreach (var item in SongList)

            {

                if (item.DateDownloaded == dateCreated)

                {

                    li.Add(item);

                }

            }

            return li;

        }

    }
}

