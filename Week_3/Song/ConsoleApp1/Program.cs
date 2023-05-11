using System.Security.Cryptography;

namespace COMP123_W3_Lab2
{
    public enum SongGenre { 
        Unclassified = 0,
        Pop = 0b1,
        Rock = 0b10,
        Blues = 0b100,
        Country = 0b1_000,
        Metal = 0b10_000,
        Soul = 0b100_000

    }
    class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public double Length;
        public SongGenre Genre { get; }
        public Song(string title, string artist, double length, SongGenre songGenre)
        {
            Title = title;
            Artist = artist;
            Length = length;
            Genre = songGenre;
        }
        public override string ToString()
        {
            return $"{Title} by {Artist} ({Genre}) {Length}min";
        }

        static void Main(string[] args)
        {
            //To test the constructor and the ToString method
            Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));

            //This is first time that you are using the bitwise or. It is used to specify a combination of genres
            Console.WriteLine(new Song("The Promise", "Chris Cornell", 4.26, SongGenre.Country | SongGenre.Rock));

            Library.LoadSongs("Week_03_lab_09_songs4.txt");     //Class methods are invoke with the class name
            Console.WriteLine("\n\nAll songs");
            Library.DisplaySongs();

            SongGenre genre = SongGenre.Rock;
            Console.WriteLine($"\n\n{genre} songs");
            Library.DisplaySongs(genre);

            string artist = "Bob Dylan";
            Console.WriteLine($"\n\nSongs by {artist}");
            Library.DisplaySongs(artist);

            double length = 5.0;
            Console.WriteLine($"\n\nSongs more than {length}mins");
            Library.DisplaySongs(length);

        }
    }
}