﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_5
{
    public class Song
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

        public Song(string name, string artist, string songType, DateTime dateDownloaded, double rating, int numberOfDownloads)

        {

            Name = name;

            Artist = artist;
            
            SongType = songType;

            Rating = rating;

            NumberOfDownloads = numberOfDownloads;

            DateDownloaded = dateDownloaded;

        }
        public static SortedDictionary<string, int>CalculateTypeCount(List<Song> list)
        {
            SortedDictionary<string,int>sdl=new SortedDictionary<string,int>();
            {
                foreach(var item in list)
                {
                    if (sdl.ContainsKey(item.SongType))
                        sdl[item.SongType]++;
                    else
                        sdl.Add(item.SongType, 1);
                      

                    }
                return sdl;

            }
            
        }
    }
}
