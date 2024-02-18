using System;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedTimes=int.Parse(Console.ReadLine());
            string input=Console.ReadLine();
            string lastExercise=string.Empty;
            int evoluationSum = 0;
            int evoluationCount = 0;
            int failedCount = 0;
            int evoluation;

            while(input!="Enough")
            {
                lastExercise = input;
                evoluation=int.Parse(Console.ReadLine());
                if(evoluation<=4)
                {
                    failedCount++;

                    if(failedCount == failedTimes) 
                    {
                        Console.WriteLine($"You need a break, {failedTimes} poor grades.");
                        break;
                    }
                }
                evoluationSum += evoluation;
                evoluationCount++;
                input = Console.ReadLine();
            }
            if (input=="Enough")
            {
                Console.WriteLine($"Average score: {(double)evoluationSum / evoluationCount:f2}");
                Console.WriteLine($"Number of problems: {evoluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");

            }
        }
    }
}
