using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());

        for (int num = M; num >= N; num--)
        {
            if (num % 2 == 0 && num % 3 == 0)
            {
                if (num == S)
                {
                    break;
                }
                else
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
