using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type=Console.ReadLine();
            int rows=int.Parse(Console.ReadLine());
            int columns=int.Parse(Console.ReadLine());
            int countTickets=rows*columns;
            double priceTicket = 0;

            switch(type)
            {
                case "Premiere":
                    priceTicket = 12;
                    break;
                case "Normal":
                    priceTicket = 7.50;
                    break;
                case "Discount":
                    priceTicket = 5;
                    break;

            }
            double profit = countTickets * priceTicket;
            Console.WriteLine($"{profit:F2} leva");
        }
    }
}
