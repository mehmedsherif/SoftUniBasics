using System;

namespace ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();

            while (true)
            {
                if(text=="Stop")
                {
                    break;
                }
                Console.WriteLine(text);
                text=Console.ReadLine();

            }
        }
    }
}
