using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_C__Program
{
    public class FibonacciSeries
    {
        public int fibonacciSeries;
        public long fab;

        public FibonacciSeries(int num)
        {
            fibonacciSeries = FabNumber(num);
            fab = fabwithformula(num);
            Console.Write("Fibonacci Series of {0} are ",num);
            for (int i = 0; i < num; i++)
            {
                Console.Write(FabSeries(i) + " ");
            }
            Console.WriteLine();
        }
        protected int FabNumber(int n)
        {
            int first = 0;
            int second = 1;

            for (int i = 1; i < n; i++)
            {
                int next = first + second;
                first = second;
                second = next;
            }

            return second; 
        }
        protected int FabSeries(int n)
        {
            if(n <= 1)
            {
                return n;
            }
            return FabSeries(n - 1) + FabSeries(n - 2);
        }
        protected long fabwithformula(int n)
        {
            double sqrt5 = Math.Sqrt(5);
            double a = Math.Pow(1 + sqrt5, n);
            double b = Math.Pow(1 - sqrt5, n);
            double den = Math.Pow(2, n) * sqrt5;

            return (long)Math.Round((a - b) / den);
        }
    }
}
