using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPP.Models
{
    public class Theatre
    {
        private List<Show> shows = new List<Show>();
        public string Name { get; }
        public Theatre(string name)
        {
            Name = name;
        }
        public void AddShow(Show show)
        {
            shows.Add(show);
        }
        public void PrintShows()
        {
            foreach (Show currentShow in shows)
            {
                Console.WriteLine(currentShow);
            }
        }
        public void PrintShows(Genre genre)
        {
            foreach (Show currentShow in shows)
            {
                if (currentShow.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine(currentShow);
                }
            }
        }
        public void PrintShows(Day day)
        {
            foreach (Show currentShow in shows)
            {
                if (currentShow.Day.Equals(day))
                {
                    Console.WriteLine(currentShow);
                }
            }
        }
        public void PrintShows(Time time)
        {
            foreach (Show currentShow in shows)
            {
                if (currentShow.Time == time)
                {
                    Console.WriteLine(currentShow);
                }
            }
        }
        public void PrintShows(string actor)
        {
            foreach (Show currentShow in shows)
            {
                if (currentShow.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine(currentShow);
                }
            }
        }
        public void PrintShows(Day day, Time time)
        {
            foreach (Show currentShow in shows)
            {
                if (currentShow.Day.Equals(day) && currentShow.Time == time)
                {
                    Console.WriteLine(currentShow);
                }
            }
        }
    }
}
