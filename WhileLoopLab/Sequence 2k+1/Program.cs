using System;

namespace Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 1;

            while (temp<=n)
            {
                Console.WriteLine(temp);
                temp = temp * 2 + 1;

            }
        }
    }
}
