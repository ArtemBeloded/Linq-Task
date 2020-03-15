using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение: ");
            int num;
            if (Int32.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Рассчитанное число: {0}", FibonacciCalculation.Fibonacci_Linq(num));
            }
            else 
            {
                Console.WriteLine("Введено некорректное значение");
            }
            

        }
    }
}
