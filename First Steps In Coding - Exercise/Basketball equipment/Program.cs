using System;

namespace Basketball_equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear=int.Parse(Console.ReadLine());
            double shoes = taxPerYear - taxPerYear*0.4;
            double outfit = shoes - shoes * 0.2;
            double ball = outfit / 4;
            double acc = ball / 5;
            double sum = taxPerYear + shoes + outfit +ball+ acc;

            Console.WriteLine(sum);
        }
    }
}
