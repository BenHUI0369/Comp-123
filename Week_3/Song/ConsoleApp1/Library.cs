using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;

namespace COMP123_W3_Lab2
{
    class Library
    {
        private static List<Song> songs;
        public static void LoadSongs(string filename)
        {
            songs = new List<Song>();
            TextReader reader = new StreamReader("Week_03_lab_09_songs4.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string title = Convert.ToString(line);
                string artist = Convert.ToString(reader.ReadLine());
                double length = Convert.ToDouble(reader.ReadLine());
                SongGenre genre = (SongGenre)Enum.Parse(typeof(SongGenre), reader.ReadLine());
                songs.Add(new Song(title, artist, length, genre));
            }


        }
        public static void DisplaySongs()
        {
            foreach (Song s in songs)
            {
                Console.WriteLine(s);
            }
        }
        public static void DisplaySongs(double longerThan)
        {
            foreach (Song s in songs)
            {
                if (s.Length > longerThan)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void DisplaySongs(SongGenre genre)
        {
            foreach (Song s in songs)
            {
                if (s.Genre == genre)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void DisplaySongs(string artist)
        {
            foreach (Song s in songs)
            {
                if (s.Artist == artist)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
