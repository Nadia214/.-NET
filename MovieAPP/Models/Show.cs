using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPP.Models
{
    public class Show
    {
        public double Price { get; }
        public Day Day { get; }
        public Time Time { get; }
        public Movie Movie { get; }
        public Show(Movie movie, Day day, double price, Time time)
        {
            Price = price;
            Day = day;
            Movie = movie;
            Time = time;
        }
        public override string ToString()
        {
            return $"Day: {Day}\nTime: {Time}\nMovie: {Movie}\n-------------------- \nPrice: { Price}\n";
        }
    }
}
