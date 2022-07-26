using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPP.Models
{
    public struct Time
    {
        private int hours;
        private int minutes;
        private int seconds; 
   
        public Time(int hours, int minutes = 0, int seconds = 0)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public static bool operator ==(Time lhs, Time rhs)
        {
            return Math.Abs(lhs.hours * 60 + lhs.minutes - rhs.hours * 60 - rhs.minutes) <= 15;


            // converted the hours and minutes in minutes using the formula -Total mins = hours*60 + mins
            // then  used absolute value of sum to make sure, negative values are not entertained.
           // int min = Math.Abs(lhs.minutes - rhs.minutes);  
          //  int hour = Math.Abs(lhs.hours - rhs.hours);
           // int time =  min + hour * 60;

           // if (time < 15)
             //   return true;
            //return false;
        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            return !(lhs == rhs);
        }
        public override string ToString()
        {
            return hours + ":" + minutes;
        }
    }
}
