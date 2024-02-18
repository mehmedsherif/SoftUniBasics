using System;

namespace EasterCompetition6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakers=int.Parse(Console.ReadLine());
            int winnerPoints = 0;
            string winnerName = "";

            for (int i = 0; i < bakers; i++)
            {
                string bakerName=Console.ReadLine();
                string command=Console.ReadLine();

                int bakerPoints = 0;

                while (command!="Stop")
                {
                    int points=int.Parse(command);

                    bakerPoints += points;

                    command=Console.ReadLine();


                }
                Console.WriteLine($"{bakerName} has {bakerPoints} points.");

                if (bakerPoints>winnerPoints)
                {
                    winnerPoints = bakerPoints;
                    winnerName = bakerName;
                    Console.WriteLine($"{bakerName} is the new number 1");
                }

            }
            Console.WriteLine($"{winnerName} won the competition with {winnerPoints} points!"); 
        }
    }
}
