using System.Diagnostics.CodeAnalysis;
using System;

namespace Lambada
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambada expression with delegate 
            Calculator calc = new Calculator();
            calc.DoSum(((x,y) => 
            {
                return x*y;
            }),5,6);
        }
    }
    class Calculator
    {
        public delegate int Sum(int a, int b);
        public void DoSum(Sum sum,int a,int b)
        {
            Console.WriteLine(sum.Invoke(a,b));
        }
    }
}
