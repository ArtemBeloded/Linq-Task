using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGrouping
{
    public static class FillingCollection
    {
        private static NumberCollection myCollection;
        private static Random rnd;

        public static List<int> Filling()
        {
            myCollection = new NumberCollection();
            rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                myCollection.collection.Add(rnd.Next(100));
            }

            return myCollection.collection;
        }
    }
}
