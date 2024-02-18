using System;

namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length=int.Parse(Console.ReadLine());
            int width=int.Parse(Console.ReadLine());
            int height=int.Parse(Console.ReadLine());
            double percent=double.Parse(Console.ReadLine());

            double litresWater = length * width * height;
            double volumeInLitres = litresWater/1000;
            double occupiedSpace = percent/100;
            double neededLitres = volumeInLitres *(1- occupiedSpace);
            Console.WriteLine(neededLitres);
        }
    }
}
