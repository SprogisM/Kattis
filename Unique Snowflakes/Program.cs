using System;
using System.Collections.Generic;

namespace Unique_Snowflakes
{
    class Program
    {
        static void Main(string[] args)
        {

            int cases, lines, line;

            cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                lines = int.Parse(Console.ReadLine());
                int max_u = 0;
                Dictionary<int, char> mapping = new Dictionary<int, char>();
                List<int> q = new List<int>();
                for (int j = 0; j < lines; j++)
                {
                    line = int.Parse(Console.ReadLine());
                    if (!mapping.ContainsKey(line))
                    {
                        mapping[line] = ' ';
                        q.Insert(0, line);
                    }
                    else
                    {
                        while (q.Count != 0 && q[q.Count - 1] != line)
                        {
                            mapping.Remove(q[q.Count - 1]);
                            q.RemoveAt(q.Count - 1);
                        }
                        q.Insert(0, line);
                        q.RemoveAt(q.Count - 1);
                    }
                    max_u = Math.Max(max_u, (int)q.Count);
                }
                Console.WriteLine(max_u);
            }
        }
    }
}
