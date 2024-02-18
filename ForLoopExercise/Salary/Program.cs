using System;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabsCount=int.Parse(Console.ReadLine());
            int salary=int.Parse(Console.ReadLine());

            for (int tab = 1; tab <= tabsCount; tab++)
            {
                string site = Console.ReadLine();

                if(site == "Facebook")
                {
                    salary -= 150;
                }
                else if (site == "Instagram")
                {
                    salary -= 100;
                }
                else if (site == "Reddit")
                {
                    salary -= 50;
                }
                if(salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if(salary>0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
