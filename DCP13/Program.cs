using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace DCP13
{
    class Program
    {
        static void Main(string[] args)
        {
#if !ONLINE_JUDGE
            //Console.SetIn(File.OpenText("file.txt"));
            //Console.SetOut(File.CreateText("out.txt"));
#endif
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string s = Console.ReadLine();
                string[] runs1 = s.Split(' ');
                s = Console.ReadLine();
                string[] runs2 = s.Split(' ');
                int bangladesh1 = prs(runs1[0]) + prs(runs1[1]);
                int bangladesh2 = prs(runs2[0]) + prs(runs2[1]);
                int pakistan1 = prs(runs1[2]) + prs(runs1[3]);
                int pakistan2 = prs(runs2[2]) + prs(runs2[3]);

                if (bangladesh1 > pakistan1 && bangladesh2 > pakistan2)
                    Console.WriteLine("Banglawash");
                else
                    Console.WriteLine("Miss");
            }
        }

        private static int prs(string v)
        {
            return Int32.Parse(v);
        }
    }
}
