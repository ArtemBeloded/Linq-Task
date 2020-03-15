using System;

namespace Fibonacci
{
    public class FibonacciCalculation
    {
        public static int Fibonacci_Linq(int num) 
        {
            Func<int, int> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;
            return fib(num);
        }
    }
}
