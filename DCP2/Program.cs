using System;
using System.IO;
using System.Net;

namespace DCP2
{
    class Program
    {
        static void Main(string[] args)
        {
#if !ONLINE_JUDGE
            Console.SetIn(File.OpenText("file.txt"));
            //Console.SetOut(File.CreateText("out.txt"));
#endif

            long E;
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                E = Convert.ToInt64(s);
                long n = Convert.ToInt64(Console.ReadLine());
                long[] keys = new long[n];
                keys[0] = Convert.ToInt64(Console.ReadLine());
                long gcd = keys[0];
                for (int i = 1; i < n; i++)
                {
                    keys[i] = Convert.ToInt64(Console.ReadLine());
                    gcd = GCD(keys[i], gcd);
                }

                if (gcd % 2 == 0)
                    gcd--;
                while (gcd != 0)
                {
                    if (!IsPrime(gcd))
                    {
                        gcd -= 2;
                        continue;
                    }

                    bool flag = true;
                    foreach (var key in keys)
                    {
                        if (key % gcd != 0)
                            flag = false;
                    }

                    if (flag == true)
                        break;
                    gcd -= 2;
                }

                long sum = 0;

                foreach (var key in keys)
                    sum += key / gcd;
                E -= sum;
                Console.WriteLine("Output: {0}", E);
                Console.ReadLine();
            }
        }

        private static bool IsPrime(long num)
        {
            long sq = (long) Math.Sqrt((double) num);
            sq++;
            for(int i=2;i<sq;i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        private static long GCD(long a, long b)
        {
            if (a > b && a % b == 0)
                return b;
            else if (b > a && b % a == 0)
                return a;
            else if (a > b)
                return GCD(b, a % b);
            else
                return GCD(a, b % a);

        }
    }
}
