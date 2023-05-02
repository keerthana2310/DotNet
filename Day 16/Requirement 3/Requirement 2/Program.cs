using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            Console.WriteLine("Enter the play list name:");
            string s = Console.ReadLine();
            PlayList playList = new PlayList(s,list);
            
            
            
                Console.WriteLine("1.Add Song \n 2.Remove Song\n 3.Display\n4.Exit");
                Console.WriteLine("Enter the choice");
            
            int ch =int.Parse( Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter the number of songs");
                    int num=int.Parse( Console.ReadLine());
                    for(int i=0; i < num;i++)
                    {
                        Console.WriteLine("Enter song {0} details", i + 1);
                        string details= Console.ReadLine();
                        Song song = new Song();
                        song=Song .CreateSong(details);
                        list.Add(song);
                        
                        //static called using class name
                        
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the song to be delected");
                    string delete= Console.ReadLine();
                    PlayList p = new PlayList();
                  bool a=  p.RemoveSongFromPlaylist(delete);
                    if(a)
                    {
                        Console.WriteLine("Song successfully deleted");
                    }
                    else
                    {
                        Console.WriteLine("song is not deleted");
                    }
                    break;

            }

        }
    }
}
