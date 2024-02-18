using System;

namespace Balls4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balls=int.Parse(Console.ReadLine());
            int redCounter = 0;
            int orangeCounter = 0;
            int yellowCounter = 0;
            int whiteCounter = 0;
            int blackCounter = 0;
            int otherCounter = 0;
            int points = 0;

            for (int i = 0; i < balls; i++)
            {
                string nextColor=Console.ReadLine();

                if(nextColor =="red")
                {
                    redCounter++;
                    points += 5;
                }
                else if (nextColor =="orange")
                {
                    orangeCounter++;
                    points += 10;
                }
                else if (nextColor =="yellow")
                {
                    yellowCounter++;
                    points += 15;

                }
                else if (nextColor =="white")
                {
                    whiteCounter++;
                    points += 20;

                }
                else if (nextColor =="black")
                {
                    blackCounter++;
                    points /= 2;

                }
                else
                {
                    otherCounter++;

                }

            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redCounter}");
            Console.WriteLine($"Orange balls: {orangeCounter}");
            Console.WriteLine($"Yellow balls: {yellowCounter}");
            Console.WriteLine($"White balls: {whiteCounter}");
            Console.WriteLine($"Other colors picked:{otherCounter}");
            Console.WriteLine($"Divides from black balls: {blackCounter}");
        }
    }
}
