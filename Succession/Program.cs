using System;
using System.Collections.Generic;

namespace Succession
{
    class Program
    {
        public Dictionary<string, string[]> children;
        public List<string> claimants;
        public Program()
        {
            children = new Dictionary<string, string[]>();
            claimants = new List<string>();
        }

        public decimal bloodLine(string child)
        {

            if (!children.ContainsKey(child))
            {
                return .0M;
            }
            else if (children[child] == null)
            {
                return 1M;
            }
            else
            {
                return (bloodLine(children[child][0]) + bloodLine(children[child][1])) / 2;
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            int[] first = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            int N = first[0];
            int M = first[1];

            p.children.Add(Console.ReadLine(), null);

            for (int i = 0; i < N; i++)
            {
                string[] relations = Console.ReadLine().Split(" ");
                string[] parents = { relations[1], relations[2] };

                p.children.Add(relations[0], parents);
            }

            for (int i = 0; i < M; i++)
            {
                p.claimants.Add(Console.ReadLine());
            }

            decimal bestBlood = 0.0M;
            string bestClaim = "";
            foreach (string claimant in p.claimants)
            {
                decimal blood = p.bloodLine(claimant);

                if (bestBlood < blood)
                {
                    bestBlood = blood;
                    bestClaim = claimant;
                }
            }

            Console.WriteLine(bestClaim);
        }
    }


}

