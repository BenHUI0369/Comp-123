using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W5_Lab1
{
    class Theatre
    {
        private List<Show> shows;
        public string Name { get; }
        public Theatre(string name)
        {
            Name = name;
            shows = new List<Show>();
        }
        public void AddShow(Show show)
        {
            shows.Add(show);
        }
        public void PrintShows()
        {
            Console.WriteLine(Name);
            Console.WriteLine("All shows");
            Console.WriteLine("=============");
            for (int i = 0; i < shows.Count; i++)
            {
                //printing all show with index
                Console.WriteLine($"{i+1,2}: {shows[i]}");
            }
            Console.WriteLine();
        }
        public void PrintShows(GenreEnum genre)
        {
            Console.WriteLine(Name);
            Console.WriteLine($"{genre} movies");
            Console.WriteLine("=============");
            int index = 0;
            for (int i = 0; i < shows.Count; i++)
            {
                //******Important notes******
                //compare the genre input with the [Flag] GrnreEnum using HasFlag method
                //in this case, inside the List, we have <Show> class. inside <Show> class, we have Movie,
                //therefore if we want to find the property, we should use the format of :
                //<Show>.<Movie>.property which (in this case) is shows[index].Movie.Genre.
                if (shows[i].Movie.Genre.HasFlag(genre))
                    Console.WriteLine($"{++index,2}: {shows[i]}");
            }
            Console.WriteLine();
        }
        public void PrintShows(DayEnum day)
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Movies on {day}");
            Console.WriteLine("=============");
            int index = 0;
            for (int i = 0; i < shows.Count; i++)
            {
                //day porperty is inside <Show> class, therefore shows[index].Day
                if (day == shows[i].Day)
                    Console.WriteLine($"{++index,2}: {shows[i]}");
            }
            Console.WriteLine();
        }
        public void PrintShows(Time time)
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Movies @{time}");
            Console.WriteLine("=============");
            int index = 0;
            for (int i = 0; i < shows.Count; i++)
            {
                //time porperty is inside <Show> class, therefore shows[index].Time
                if (time == shows[i].Time)
                Console.WriteLine($"{++index,2}: {shows[i]}");
            }
            Console.WriteLine();
        }
        public void PrintShows(string actor)
        {
            Console.WriteLine(Name);
            Console.WriteLine($"{actor} movies");
            Console.WriteLine("=============");
            int index = 0;
            for (int i = 0; i < shows.Count; i++)
            {
                //Cast is one of the Movie porperty, therefore we have to call Cast after Movie:
                //shows[index].Movie.Case
                if (shows[i].Movie.Cast.Contains(actor))
                    Console.WriteLine($"{++index,2}: {shows[i]}");
            }
            Console.WriteLine();
        }
        public void PrintShows(DayEnum day, Time time)
        {

        }
    }
}
