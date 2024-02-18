using System;

namespace DaysOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string WeekendOrWorkingDay =Console.ReadLine();

            switch (WeekendOrWorkingDay)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday": Console.WriteLine("Working day");break;

                case "Saturday": 
                case "Sunday": Console.WriteLine("Weekend"); break;
                default: Console.WriteLine("Error"); break;







            }
        }
    }
}
