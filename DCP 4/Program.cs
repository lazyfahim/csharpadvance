using System;
using System.IO;

namespace DCP_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
#if !ONLINE_JUDGE
            Console.SetIn(File.OpenText("file.txt"));
            //Console.SetOut(File.CreateText("out.txt"));
#endif
            while ((s = Console.ReadLine()) != null)
            {
                string[] parames = s.Split(' ');
                int hours = Int32.Parse(parames[0]);
                int people = Int32.Parse(parames[1]);
                int totalworksbyday = 0;
                for (int i = 1; i <= people; i++)
                {
                    int hrs = Int32.Parse(Console.ReadLine());
                    totalworksbyday += hrs;
                }
                double totalday = Math.Ceiling(double.Parse(hours.ToString()) / double.Parse(totalworksbyday.ToString()));
                int day = Int32.Parse(totalday.ToString());
                string dy = day > 1 ? "days" : "day";
                Console.WriteLine($"Project will finish within {day} {dy}." );
            }
        }
    }
}
