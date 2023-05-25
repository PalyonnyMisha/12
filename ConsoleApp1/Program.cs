using System;

namespace FibonacciApp
{
    class Program
    {
        static void Main()
        {
            int n = 40;

            Console.WriteLine("Перші {0} чисел Фібоначчі:", n);
            for (int i = 0; i < n; i++)
            {
                long fibonacciNumber = Fibonacci(i);
                Console.WriteLine(fibonacciNumber);
            }

            Console.ReadLine();
        }

        static long Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            long previous = 0;
            long current = 1;

            for (int i = 2; i <= n; i++)
            {
                long next = previous + current;
                previous = current;
                current = next;
            }

            return current;
        }
    }
}
