﻿using System;

namespace WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours=int.Parse(Console.ReadLine());
            string dayOfWeek=Console.ReadLine();

            if(dayOfWeek=="Monday"|| dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday" || dayOfWeek == "Saturday")
            {
                if(hours>=10 && hours<=18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
               
            }
            else if (dayOfWeek == "Sunday")
            {
                Console.WriteLine("closed");
            }
        }
    }
}
