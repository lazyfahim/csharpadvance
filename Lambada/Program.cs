using System.Diagnostics.CodeAnalysis;
using System;

namespace Lambada
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambada expression inline with delegate 
            Calculator calc = new Calculator();
            calc.DoSum(((x,y) => x+y),5,6);
            //lambada expression multiple statement with delegate 
            calc.DoSum(((x,y) => 
            {
                return x+y;
            }),7,8);

            //lambada expression with Func 
            calc.DoSumF((x,y)=> x+y,10,5);
        }
    }
    class Calculator
    {
        public delegate int Sum(int a, int b);
        public void DoSum(Sum sum,int a,int b)
        {
            Console.WriteLine(sum.Invoke(a,b));
        }
        public void DoSumF(Func<int,int,int> sum,int a,int b)
        {
            Console.WriteLine(sum.Invoke(a,b));
        }
    }
}
