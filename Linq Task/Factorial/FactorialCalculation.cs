using System.Linq;


namespace Factorial
{
    public class FactorialCalculation
    {
        public static int Factorial_Linq(int num)
        {
            return Enumerable.Range(1, num).Aggregate((a, b) => a * b);
        }

        public static int Factorial_Recursion(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial_Recursion(num - 1);
            }
        }
    }
}
