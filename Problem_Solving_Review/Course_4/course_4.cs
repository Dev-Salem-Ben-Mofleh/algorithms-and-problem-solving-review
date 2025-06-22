using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Review.Course_4
{
    public class course_4
    {

        public static int Factorial(int n)
        {
            if (n == 0) return 0;

            int Factorial = 1;

            for (int i = n; i > 0; i--)
            {
                Factorial = Factorial * i;
            }
            return Factorial;
        }

        public static float GatDayCount(int numberOfHours)
        {
            if (numberOfHours == 0) return 0;

            return (float)numberOfHours / 24;
        }

        public static float GatWeekCount(int numberOfDays)
        {
            if (numberOfDays == 0) return 0;

            return (float)numberOfDays / 7;
        }

        public static int MiuntsToSecond(int Miunts)
        {
            if (Miunts == 0) return 0;

            return Miunts * 60;
        }

        public static int HoursToMiunts(int Hours)
        {
            if (Hours == 0) return 0;

            return Hours * 60;
        }

        public static int DaysToHours(int Days)
        {
            if (Days == 0) return 0;

            return Days * 24;
        }


        public static int HoursToSeconds(int Hours)
        {
            if (Hours == 0) return 0;

            return (MiuntsToSecond(HoursToMiunts(Hours)));
        }


        public static int DaysToSecond(int Days)
        {
            if (Days == 0) return 0;

            return (HoursToSeconds(DaysToHours((Days))));
        }

        public static int GetTotalSeconds(int days, int hours, int miunts, int second)
        {
            return DaysToSecond(days) + HoursToSeconds(hours) + MiuntsToSecond(second) + second;
        }

        public static int SecondsToDays(int totalSeconds, out int remainder)
        {
            int secondsPerDay = 24 * 60 * 60;

            int days = totalSeconds / secondsPerDay;
            remainder = totalSeconds % secondsPerDay;

            return days;
        }

        public static int SecondsToHours(int totalSeconds, out int remainder)
        {
            int secondsPerHour = 60 * 60;

            int hours = totalSeconds / secondsPerHour;
            remainder = totalSeconds % secondsPerHour;

            return hours;
        }

        public static int SecondsToMinutes(int totalSeconds, out int remainder)
        {
            int secondsPerMinute = 60;

            int minutes = totalSeconds / secondsPerMinute;
            remainder = totalSeconds % secondsPerMinute;

            return minutes;
        }
        public static string GetTimeDuration(int TotalSecond)
        {
            int Days = SecondsToDays(TotalSecond, out int dayRemainder);
            int Hours = SecondsToHours(TotalSecond, out int hourRemainder);
            int Miunts = SecondsToDays(TotalSecond, out int second);

            return $"{Days:D2}:{Hours:D2}:{Miunts:D2}:{second:D2}";

        }


        //static void Main(string[] args)
        //{
        //    // Console.WriteLine(Factorial(10));
        //    // Console.WriteLine(GetWeeksCount(102));
        //    // Console.WriteLine(GetDaysCount(120));

        //    // Console.WriteLine(GetTotalSeconds(4, 7, 40, 55));

        //    Console.WriteLine(GetTimeDuration(193535));
        //}
    }
}