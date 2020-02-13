using System;
using System.IO;
using System.Linq;
using System.Numerics;

namespace DCP1
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
                string[] numbers = s.Split(',');
                string firstNumber =  numbers[0];
                string secondNumber = numbers[1];
                string sumstring = "";
                int len = firstNumber.Length > secondNumber.Length ? firstNumber.Length : secondNumber.Length;
                int extra = 0;
                for (int i = 0; i < len; i++)
                { 
                    int first = i < firstNumber.Length ? Int32.Parse(firstNumber.ElementAt(i).ToString()) : 0;
                    int second = i < secondNumber.Length ? Int32.Parse(secondNumber.ElementAt(i).ToString()) : 0;
                    int sum = first + second+extra;
                    if (i == len - 1)
                    {
                        sumstring += ReverseString(sum.ToString());
                        continue;
                    }
                    sumstring += (sum % 10).ToString();
                    extra = sum / 10;
                }
                
                sumstring = sumstring.TrimStart(new char[] { '0' });


                Console.WriteLine(sumstring);
            }
        }
        public static string ReverseString(string s)
        {
            char[] array = new char[s.Length];
            int forward = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                array[forward++] = s[i];
            }
            return new string(array);
        }
    }
}
