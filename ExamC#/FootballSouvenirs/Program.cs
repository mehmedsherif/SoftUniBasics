using System;

namespace WorldCupSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;

            if (country == "Argentina")
            {
                if (souvenir == "flags")
                    price = 3.25;
                else if (souvenir == "caps")
                    price = 7.20;
                else if (souvenir == "posters")
                    price = 5.10;
                else if (souvenir == "stickers")
                    price = 1.25;
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (country == "Brazil")
            {
                if (souvenir == "flags")
                    price = 4.20;
                else if (souvenir == "caps")
                    price = 8.50;
                else if (souvenir == "posters")
                    price = 5.35;
                else if (souvenir == "stickers")
                    price = 1.20;
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (country == "Croatia")
            {
                if (souvenir == "flags")
                    price = 2.75;
                else if (souvenir == "caps")
                    price = 6.90;
                else if (souvenir == "posters")
                    price = 4.95;
                else if (souvenir == "stickers")
                    price = 1.10;
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (country == "Denmark")
            {
                if (souvenir == "flags")
                    price = 3.10;
                else if (souvenir == "caps")
                    price = 6.50;
                else if (souvenir == "posters")
                    price = 4.80;
                else if (souvenir == "stickers")
                    price = 0.90;
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
                return;
            }

            double totalPrice = price * quantity;
            Console.WriteLine($"Pepi bought {quantity} {souvenir} of {country} for {totalPrice:f2} lv.");
        }
    }
}
