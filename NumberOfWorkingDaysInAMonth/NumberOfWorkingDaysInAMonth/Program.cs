using System;

namespace NumberOfWorkingDaysInAMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "2018-07";
            Console.WriteLine("Test");
            //Get what day of week it is for startdate and for enddate of month
            
            DateTime startDateOfMonth = new DateTime(Convert.ToInt32(input.Substring(0, 4)), Convert.ToInt32(input.Substring(4, 2)), 1);

            DateTime endDateOfMonth = new DateTime();

            //if it starts and ends on weekday only 4 weekends

            //if it starts on Friday or weekend and ends between weekend and Tuesday and difference is less than 3 between days then 9 days

            //if it starts on Saturday and ends on Monday then 10 days to the weekend
        }
    }
}