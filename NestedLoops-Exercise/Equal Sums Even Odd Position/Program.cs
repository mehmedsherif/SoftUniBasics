﻿using System;

namespace Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first=int.Parse(Console.ReadLine());
            int second=int.Parse(Console.ReadLine());

            for (int num = first; num <=second; num++)
            {
                int oddSum = 0;
                int evenSum = 0;

                string currentNum=num.ToString();

                for (int i = 0; i <currentNum.Length; i++)
                {
                    if(i%2==0)
                    {
                        evenSum += currentNum[i];
                    }
                    else
                    {
                        oddSum += currentNum[i];
                    }

                }
                if(evenSum==oddSum)
                {
                    Console.Write(currentNum + " ");
                }

            }
        }
    }
}
