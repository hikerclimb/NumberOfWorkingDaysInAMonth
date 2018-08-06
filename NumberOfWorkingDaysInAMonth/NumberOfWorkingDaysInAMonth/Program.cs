using System;

namespace NumberOfWorkingDaysInAMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "2050-02";
            //Get what day of week it is for startdate and for enddate of month
            int year = Convert.ToInt32(input.Substring(0, 4));
            int month = Convert.ToInt32(input.Substring(5, 2));

            DateTime startDateOfMonth = new DateTime(year, month, 1);
            DateTime endDateOfMonth = new DateTime(year, month, System.DateTime.DaysInMonth(year, month));

            DayOfWeek startDayOfMonth = startDateOfMonth.DayOfWeek;
            DayOfWeek endDayOfMonth = endDateOfMonth.DayOfWeek;

            Console.WriteLine("startDayOfMonth:" + startDayOfMonth);
            Console.WriteLine("endDayOfMonth:" + endDayOfMonth);

            //if it starts and ends on weekday only 4 weekends
            if((startDayOfMonth == DayOfWeek.Monday || startDayOfMonth == DayOfWeek.Tuesday || startDayOfMonth == DayOfWeek.Wednesday || startDayOfMonth == DayOfWeek.Thursday || startDayOfMonth == DayOfWeek.Friday) && (endDayOfMonth == DayOfWeek.Monday || endDayOfMonth == DayOfWeek.Tuesday || endDayOfMonth == DayOfWeek.Wednesday || endDayOfMonth == DayOfWeek.Thursday || endDayOfMonth == DayOfWeek.Friday))
            {
                Console.WriteLine("8 weekend days in a month");
            }
            //if it starts on Saturday and ends on Monday then 10 days to the weekend
            else if ((startDayOfMonth == DayOfWeek.Friday || startDayOfMonth == DayOfWeek.Saturday) && (endDayOfMonth == DayOfWeek.Monday || endDayOfMonth == DayOfWeek.Sunday))
            {
                Console.WriteLine("10 weekend days in a month");
            }
            //if it starts on Friday or weekend and ends between weekend and Tuesday and difference is less than 3 between days then 9 days
            else if((startDayOfMonth == DayOfWeek.Thursday || startDayOfMonth == DayOfWeek.Friday || startDayOfMonth == DayOfWeek.Saturday || startDayOfMonth == DayOfWeek.Sunday) && (endDayOfMonth == DayOfWeek.Saturday || endDayOfMonth == DayOfWeek.Sunday || endDayOfMonth == DayOfWeek.Monday || endDayOfMonth == DayOfWeek.Tuesday))
            {
                Console.WriteLine("9 weekend days in a month");
            }

            Console.ReadLine();
        }
    }
}