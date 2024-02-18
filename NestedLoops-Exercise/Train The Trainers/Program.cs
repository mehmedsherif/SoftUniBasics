using System;

class Program
{
    static void Main(string[] args)
    {
        int juryMembersCount = int.Parse(Console.ReadLine());
        string presentationName = Console.ReadLine();

        double totalAverageScore = 0;
        int presentationCount = 0;

        while (presentationName != "Finish")
        {
            double presentationSum = 0;

            for (int i = 0; i < juryMembersCount; i++)
            {
                double score = double.Parse(Console.ReadLine());
                presentationSum += score;
            }

            double presentationAverageScore = presentationSum / juryMembersCount;
            Console.WriteLine($"{presentationName} - {presentationAverageScore:F2}.");

            totalAverageScore += presentationAverageScore;
            presentationCount++;

            presentationName = Console.ReadLine();
        }

        double finalAverageScore = totalAverageScore / presentationCount;
        Console.WriteLine($"Student's final assessment is {finalAverageScore:F2}.");
    }
}
