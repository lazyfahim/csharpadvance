using System;

namespace DelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(200,15);
            var calcdel = new Calculator.Calculate(add);
            var calcdelsub = new Calculator.Calculate(sub);
            calc.Result(calcdel);
            calc.Result(calcdelsub);
        }
        static void add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        static void sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
    }

    public class Calculator
    {
        private int a,b;
        public Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public delegate void Calculate(int a, int b);
        public void Result(Calculate calculate)
        {
            calculate(a,b);
        }

    }
}
