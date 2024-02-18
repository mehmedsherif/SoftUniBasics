using System;

namespace CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            string filmName = Console.ReadLine();

            while (filmName != "Finish")
            {
                int free = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                int tickets = 0;

                while (type != "End")
                {
                    if (type == "student")
                    {
                        studentTickets++;
                    }
                    else if (type == "standard")
                    {
                        standardTickets++;
                    }
                    else
                    {
                        kidTickets++;
                    }
                    tickets++;

                    if (tickets == free)
                    {
                        break;
                    }

                    type = Console.ReadLine();
                }

                Console.WriteLine($"{filmName} - {(double)tickets * 100 / free:f2}% full.");
                filmName = Console.ReadLine();
            }

            int totalTickets = studentTickets + standardTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)studentTickets * 100 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{(double)standardTickets * 100 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidTickets * 100 / totalTickets:f2}% kids tickets.");
        }
    }
}
