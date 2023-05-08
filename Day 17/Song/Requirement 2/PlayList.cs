using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Requirement_2
{
    internal class PlayList
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private List<Song> _songList = new List<Song>();
        public List<Song>SongList
        { get
            { return _songList; }
            set { _songList = value; }
                
        }
        public PlayList() { 
        }
        public PlayList(string name, List<Song> songList)
        {
            _name = name;
            _songList = songList;
        }
        public void AddSongToPlaylist(Song song)
        {
            _songList.Add(song);
        }
        public bool RemoveSongFromPlaylist (String name)
        {
            int count = 0;       //CAN'T use return in foreachloop.since we use boolean need true or false

            foreach (var s in _songList)
            {
                if (s.Name == name)
                {
                    _songList.Remove(s);
                  //  Console.WriteLine("Song os deleted");
                    count++;
                }
                
            }
            if(count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void DisplaySongs()
        {
            if(_songList.Count == 0){
                Console.WriteLine("No songs to show");
            }
            else
            {
                Console.WriteLine("show songs of", _songList);
            }
            
        }



    }
}
