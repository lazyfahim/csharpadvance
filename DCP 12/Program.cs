using System;
using System.IO;

namespace DCP_12
{
    class Program
    {
        static void Main(string[] args)
        {
#if !ONLINE_JUDGE
            Console.SetIn(File.OpenText("file.txt"));
            //Console.SetOut(File.CreateText("out.txt"));
#endif
        }
    }
}
