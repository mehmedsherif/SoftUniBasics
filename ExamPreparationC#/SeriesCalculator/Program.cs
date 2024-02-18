using System;

namespace SeriesCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName=Console.ReadLine();
            int seasons=int.Parse(Console.ReadLine());
            int episodes=int.Parse(Console.ReadLine());
            double episodesNoAdv=double.Parse(Console.ReadLine());

            double fullEpisode = (episodesNoAdv * 0.2)+episodesNoAdv;
            int specialEpisode = seasons * 10;
            double fullTime = (fullEpisode * seasons*episodes)+specialEpisode;

            Console.WriteLine($"Total time needed to watch the {seriesName} series is {fullTime} minutes.");

        }
    }
}
