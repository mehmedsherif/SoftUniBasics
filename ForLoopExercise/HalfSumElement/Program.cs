using System;

namespace HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int num ;
            int maxNum=int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num > maxNum)
                {
                    maxNum = num;
                }
                sum += num;
            }
            sum -= maxNum;

            if (sum==maxNum)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {maxNum}"); 
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {Math.Abs(maxNum - sum)}");
                }


            }
            
        }
    }

