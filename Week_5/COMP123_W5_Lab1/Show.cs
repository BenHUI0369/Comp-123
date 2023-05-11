using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W5_Lab1
{
    class Show
    {
        public double Price { get; }
        public DayEnum Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }
        public Show(Movie movie, Time time, DayEnum day, double price)
        {
            Movie = movie;
            Time = time;
            Day = day;
            Price = price;
        }
        public override string ToString()
        {
            //Use the string.Join(", ", Cast) to display Cast
            return $"{Day} {Time} {Movie.Title} ({Movie.Year}) {Movie.Length} ({Movie.Genre}) {string.Join(", ", Movie.Cast)} {Price:c2}";
        }
    }
}
