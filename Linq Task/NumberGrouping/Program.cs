using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGrouping
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = FillingCollection.Filling();

            var GroupingCollection = from item in collection
                                     group item by item % 2;

            Console.WriteLine("Исходный массив: \n{0}", string.Join(" ", collection));

            foreach (var group in GroupingCollection)
            {
                Console.WriteLine(group.Key == 0 ? "\nЧетные числа:" : "\nНеченые числа:");
                Console.WriteLine("{0}", string.Join(" ", group));
                Console.WriteLine(" ");
            }

        }
    }
}
