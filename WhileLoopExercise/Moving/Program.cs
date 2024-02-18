using System;

class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int totalVolume = width * length * height;
        int remainingVolume = totalVolume;

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Done")
            {
                break;
            }

            int boxes = int.Parse(command);
            int boxVolume = 1;  // Обемът на един кашон е 1 кубичен метър

            if (remainingVolume >= boxes * boxVolume)
            {
                remainingVolume -= boxes * boxVolume;
            }
            else
            {
                Console.WriteLine($"No more free space! You need {boxes * boxVolume - remainingVolume} Cubic meters more.");
                return;
            }
        }

        Console.WriteLine($"{remainingVolume} Cubic meters left.");
    }
}
