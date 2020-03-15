using System;
using System.Linq;


namespace DataGrouping
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = FillingCollection.Filling();

            var GroupingCollection = from item in collection
                              group item by item.size;

            var groupedCollection = GroupingCollection.SelectMany(group => group).ToList();

            foreach (var item in collection)
            {
                Console.WriteLine("Address: {0}, Color: {1}, Size: {2}", item.address, item.color, item.size);
            }
            Console.WriteLine(" ");
            foreach (var item in groupedCollection)
            {
                Console.WriteLine("Address: {0}, Color: {1}, Size: {2}", item.address, item.color, item.size);
            }

        }
    }
}
