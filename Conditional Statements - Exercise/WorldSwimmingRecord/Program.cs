using System;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord=double.Parse(Console.ReadLine());
            double distance=double.Parse(Console.ReadLine());
            double timePerMeter=double.Parse(Console.ReadLine());

            double recordByIvan = distance * timePerMeter;
            double delay = distance / 15;
            recordByIvan+=Math.Floor(delay)*12.5;
            if(recordByIvan<worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(worldRecord - recordByIvan):f2} seconds slower.");
            }
        }
    }
}
