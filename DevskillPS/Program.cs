using System;
using System.Collections.Generic;
using System.IO;

namespace DCP8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.SetIn(File.OpenText("file.txt"));
            //Console.SetOut(File.CreateText("out.txt"));
            int p = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine("Case: {0}",i+1);
                Solve();
            }
        }

        private static void Solve()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            var originalNumers = new List<string>();
            for (var i = 0; i < n; i++)
            {
                var number = Console.ReadLine();
                originalNumers.Add(number);
            }

            var deliveryReports = new List<string>();
            for (var i = 0; i < n; i++)
            {
                var number = Console.ReadLine();
                deliveryReports.Add(number);
            }

            var SuccessList = new List<string>();
            var FailedList = new List<string>();
            foreach (var report in deliveryReports)
            {
                var numberString = report.Split(',');
                var cache = "";
                var flag = -1;
                foreach (var original in originalNumers)
                {
                    if(original.Length != numberString[0].Length)
                        continue;
                    var first = original.Substring(0, 3);
                    var second = original.Substring(7, original.Length-7);
                    var firstofStarred = numberString[0].Substring(0, 3);
                    var secondofStarred = numberString[0].Substring(7, numberString[0].Length-7);
                    if (first == firstofStarred && second == secondofStarred)
                    {
                        if (flag == 1)
                        {
                            flag = 3;
                            break;
                        }

                        cache = original;
                        flag = 1;
                    }
                }

                var finalString = "";
                finalString += numberString[0]+" : ";
                if (flag == 3)
                    finalString += "Confused";
                else
                    finalString += cache;
                if (numberString[1] == "Success")
                    SuccessList.Add(finalString);
                else
                    FailedList.Add(finalString);
            }

            Console.WriteLine("Success list");
            foreach (var sucess in SuccessList) Console.WriteLine(sucess);
            Console.WriteLine("Failed list");
            foreach (var falied in FailedList) Console.WriteLine(falied);
            Console.ReadLine();
        }
    }
}