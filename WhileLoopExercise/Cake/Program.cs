using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int cakeSize=w*h;
            string input=Console.ReadLine();

            while (input != "STOP")
            {
                cakeSize -= int.Parse(input);


                if (cakeSize < 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if(cakeSize>=0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
            }
        }
    }
}
