using System;

namespace Vacation_Book_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int page=int.Parse(Console.ReadLine());
            int pagePerHours=int.Parse(Console.ReadLine());
            int days=int.Parse(Console.ReadLine());
            int time = page / pagePerHours;
            int hoursPerDay = time / days;
            Console.WriteLine(hoursPerDay);
        }
    }
}
