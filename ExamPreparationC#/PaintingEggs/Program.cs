using System;

namespace PaintingEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eggSize=Console.ReadLine();
            string eggColor=Console.ReadLine();
            int eggBox=int.Parse(Console.ReadLine());

            int boxPrice = 0;

            if( eggSize =="Large")
            {
                if ( eggColor =="Red")
                {
                    boxPrice = 16;

                }
                else if ( eggColor =="Green")
                {
                    boxPrice = 12;
                }
                else if ( eggColor =="Yellow")
                {
                    boxPrice = 9;
                }

            }
            else if( eggSize =="Medium")
            {
                if (eggColor == "Red")
                {
                    boxPrice = 13;

                }
                else if (eggColor == "Green")
                {
                    boxPrice = 9;
                }
                else if (eggColor == "Yellow")
                {
                    boxPrice = 7;
                }

            }
            else if ( eggSize =="Small")
            {
                if (eggColor == "Red")
                {
                    boxPrice = 9;

                }
                else if (eggColor == "Green")
                {
                    boxPrice = 8;
                }
                else if (eggColor == "Yellow")
                {
                    boxPrice = 5;
                }

            }
            int sales = eggBox * boxPrice;
            double profit = sales * 0.65;

            Console.WriteLine($"{profit:f2} leva.");
        }
    }
}
