using System;

namespace FuncExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,int,int> calculate;
            calculate = Sum;
            Driver driver = new Driver();
            driver.Docalculation(calculate);
        }
        static int Sum(int a, int b)
        {
            Console.WriteLine(a+b);
            return a + b;
        }
    }
    class Driver
    {
        public void Docalculation(Func<int,int,int> calculate)
        {
            calculate(5,10);
        }
    }
}
