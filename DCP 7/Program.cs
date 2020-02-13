using System;
using System.IO;
using System.Linq;

namespace DCP_7
{
    class Program
    {
        static void Main(string[] args)
        {
#if !ONLINE_JUDGE
            Console.SetIn(File.OpenText("file.txt"));
            //Console.SetOut(File.CreateText("out.txt"));
#endif
            int n = Int32.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
                solve();

        }

        private static void solve()
        {
            int len = Int32.Parse(Console.ReadLine());
            string url = Console.ReadLine();
            String shortened = "";
            foreach (var c in url)
            {
                char addingchar;
                if (c >= 'A' && c <= 'Z')
                    addingchar = Char.ToLower(c);
                else if (c >= 'a' && c <= 'z')
                    addingchar = c;
                else if (c >= '0' && c <= '9')
                    addingchar = c;
                else
                {
                    if (shortened.LastOrDefault() == '-')
                        addingchar = '\0';
                    else
                        addingchar = '-';
                }
                if (addingchar != '\0')
                    shortened += addingchar;
            }

            if (shortened.FirstOrDefault() == '-')
                shortened = shortened.Remove(0, 1);
            if (shortened.LastOrDefault() == '-')
                shortened = shortened.Remove(shortened.Length - 1, 1);
            if (shortened.Length > len)
                shortened = shortened.Remove(len);
            if (shortened.LastOrDefault() == '-')
                shortened = shortened.Remove(shortened.Length - 1, 1);
            Console.WriteLine(shortened);
        }
    }
}
