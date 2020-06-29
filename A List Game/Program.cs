using System;

namespace A_List_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int factor = 2;
            int factors = 0;

            long number = Int64.Parse(Console.ReadLine());

            while (factor * factor <= number)
            {
                if (number % factor == 0)
                {
                    factors += 1;
                    number /= factor;
                }
                else
                {
                    factor += 1;
                }
            }

            Console.WriteLine(factors + 1);
        }
    }
}