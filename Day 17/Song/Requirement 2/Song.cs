using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_2
{
    internal class Song
    {
        private string _name;

        private string _artist;

        private string _songType;

        private double _rating;

        private int _numberOfDownloads;

        private DateTime _dateDownloaded;

        public string Name

        {

            get { return _name; }

            set { _name = value; }

        }

        public string Artist

        {

            get { return _artist; }

            set { _artist = value; }

        }

        public string SongType

        {

            get { return _songType; }

            set { _songType = value; }

        }

        public double Rating

        {

            get { return _rating; }

            set

            {

                _rating = value;

            }

        }

        public int NumberOfDownloads

        {

            get { return _numberOfDownloads; }

            set

            {

                _numberOfDownloads = value;

            }

        }

        public DateTime DateDownloaded

        {

            get { return _dateDownloaded; }

            set

            {

                _dateDownloaded = value;

            }

        }

        public Song()

        {

        }

        public Song(string name, string artist, string songType, double rating, int numberOfDownloads, DateTime dateDownloaded)

        {

            Name = name;

            Artist = artist;

            SongType = songType;

            Rating = rating;

            NumberOfDownloads = numberOfDownloads;

            DateDownloaded = dateDownloaded;

        }
        public static Song CreateSong(string song)
        {

            string[] s = Console.ReadLine().Split(',');

            DateTime dt = DateTime.ParseExact(s[5], "dd-mm-yyyy", null);

            Song x = new Song(s[0], s[1], s[2], double.Parse(s[3]), int.Parse(s[4]), dt);

            return x;

        }
    }

}

