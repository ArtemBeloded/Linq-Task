using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение: ");
            int num;
            if (Int32.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Факториал рассчитан с помощью linq: {0}", FactorialCalculation.Factorial_Linq(num));
                Console.WriteLine("Факториал рассчитан с помощью linq: {0}", FactorialCalculation.Factorial_Recursion(num));
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
            }

        }
    }
}
