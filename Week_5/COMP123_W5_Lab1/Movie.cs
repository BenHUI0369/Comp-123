using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W5_Lab1
{
    class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public GenreEnum Genre { get; private set; }
        public List<string> Cast { get; }
        public Movie(string title, int year, int length)
        {
            Title = title;
            Year = year;
            Length = length;
            Cast = new List<string>();
        }
        public void AddActor(string actor)
        {
            //add the actor in to Cast list which is a string list
            Cast.Add(actor);
        }
        public void SetGenre(GenreEnum genre)
        {
            Genre = genre;
        }
    }
}
