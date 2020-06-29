using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            int[] gunnar = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int[] emma = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            float gDice1 = gunnar[1] - gunnar[0] + 1;
            float gDice2 = gunnar[3] - gunnar[2] + 1;
            float eDice1 = emma[1] - emma[0] + 1;
            float eDice2 = emma[3] - emma[2] + 1;

            score = gunnar[0] - emma[0] + gunnar[1] - emma[1] + gunnar[2] - emma[2] + gunnar[3] - emma[3];

            if (score == 0)
            {
                Console.WriteLine("Tie");
            }
            else if (score > 0)
            {
                Console.WriteLine("Gunnar");
            }
            else
            {
                Console.WriteLine("Emma");
            }
        }
    }
}
