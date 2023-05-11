using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W5_Lab1
{
    struct Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public Time(int hours, int minutes = 0)
        {
            Hours = hours;
            Minutes = minutes;
        }
        public override string ToString()
        {
            return $"{Hours:d2}:{Minutes:d2}";
        }
        public static bool operator ==(Time lhs, Time rhs)
        {
            //we have two condition, 1: (same hour absolute mintues different <=15), 2: (1 hour different and absolute mintues different >= 45)
            bool hourSame = lhs.Hours == rhs.Hours;
            bool hourcompare = Math.Abs(lhs.Hours - rhs.Hours) == 1;
            bool minuteWithIn = Math.Abs(lhs.Minutes - rhs.Minutes) <= 15;
            bool minuteWithOut = Math.Abs(lhs.Minutes - rhs.Minutes) >= 45;
            //base on the two case to return ture
            return hourSame && minuteWithIn || hourcompare && minuteWithOut;
        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            bool hourSame = lhs.Hours == rhs.Hours;
            bool hourcompare = Math.Abs(lhs.Hours - rhs.Hours) == 1;
            bool minuteWithIn = Math.Abs(lhs.Minutes - rhs.Minutes) <= 15;
            bool minuteWithOut = Math.Abs(lhs.Minutes - rhs.Minutes) >= 45;
            //base on the two case to return false
            return !(hourSame && minuteWithIn || hourcompare && minuteWithOut);
        }
    }
}
