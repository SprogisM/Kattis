using System;
using System.Collections.Generic;

namespace Eb_Alto_Saxophone_Player
{
    public enum Notes
    {
        c = 99,
        d,
        e,
        f,
        g,
        a = 97,
        b,
        C = 67,
        D,
        E,
        F,
        G,
        A = 65,
        B
    }
    class Program
    {
        public static void updateState(ref int[] state, ref int[] counter, int[] note)
        {
            int[] newState = new int[10];
            foreach (int finger in note)
            {
                if (state[finger] == 0)
                    counter[finger] += 1;

                newState[finger] += 1;
            }
            state = newState;
        }
        static void Main(string[] args)
        {

            Dictionary<Notes, int[]> data = new Dictionary<Notes, int[]>();

            int[] c = { 1, 2, 3, 6, 7, 8, 9 };
            data.Add(Notes.c, c);
            int[] d = { 1, 2, 3, 6, 7, 8 };
            data.Add(Notes.d, d);
            int[] e = { 1, 2, 3, 6, 7 };
            data.Add(Notes.e, e);
            int[] f = { 1, 2, 3, 6 };
            data.Add(Notes.f, f);
            int[] g = { 1, 2, 3 };
            data.Add(Notes.g, g);
            int[] a = { 1, 2 };
            data.Add(Notes.a, a);
            int[] b = { 1 };
            data.Add(Notes.b, b);
            int[] C = { 2 };
            data.Add(Notes.C, C);
            int[] D = { 0, 1, 2, 3, 6, 7, 8 };
            data.Add(Notes.D, D);
            int[] E = { 0, 1, 2, 3, 6, 7 };
            data.Add(Notes.E, E);
            int[] F = { 0, 1, 2, 3, 6 };
            data.Add(Notes.F, F);
            int[] G = { 0, 1, 2, 3 };
            data.Add(Notes.G, G);
            int[] A = { 0, 1, 2 };
            data.Add(Notes.A, A);
            int[] B = { 0, 1 };
            data.Add(Notes.B, B);

            int testCases = int.Parse(Console.ReadLine());

            for (int i = testCases; i > 0; i--)
            {
                int[] counter = new int[10];
                int[] state = new int[10];
                char[] notePress = Console.ReadLine().ToCharArray();
                foreach (char note in notePress)
                {
                    switch ((Notes)note.ToString()[0])
                    {
                        case Notes.c:
                            updateState(ref state, ref counter, data[Notes.c]);
                            break;
                        case Notes.d:
                            updateState(ref state, ref counter, data[Notes.d]);
                            break;
                        case Notes.e:
                            updateState(ref state, ref counter, data[Notes.e]);
                            break;
                        case Notes.f:
                            updateState(ref state, ref counter, data[Notes.f]);
                            break;
                        case Notes.g:
                            updateState(ref state, ref counter, data[Notes.g]);
                            break;
                        case Notes.a:
                            updateState(ref state, ref counter, data[Notes.a]);
                            break;
                        case Notes.b:
                            updateState(ref state, ref counter, data[Notes.b]);
                            break;
                        case Notes.C:
                            updateState(ref state, ref counter, data[Notes.C]);
                            break;
                        case Notes.D:
                            updateState(ref state, ref counter, data[Notes.D]);
                            break;
                        case Notes.E:
                            updateState(ref state, ref counter, data[Notes.E]);
                            break;
                        case Notes.F:
                            updateState(ref state, ref counter, data[Notes.F]);
                            break;
                        case Notes.G:
                            updateState(ref state, ref counter, data[Notes.G]);
                            break;
                        case Notes.A:
                            updateState(ref state, ref counter, data[Notes.A]);
                            break;
                        case Notes.B:
                            updateState(ref state, ref counter, data[Notes.B]);
                            break;
                        default:
                            break;

                    }
                }
                string answer = "";
                foreach (int count in counter)
                {
                    answer += count + " ";
                }
                Console.WriteLine(answer.Substring(0, (answer.Length - 1)));
            }


        }
    }
}
