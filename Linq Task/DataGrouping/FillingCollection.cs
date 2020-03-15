using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrouping
{
    public static class FillingCollection
    {
        private static HousesCollection myCollection;
        private static Random rnd;

        public static List<House> Filling()
        {
            myCollection = new HousesCollection();
            rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                myCollection.collection.Add(new House()
                {
                    address = String.Format("Сумська {0}", rnd.Next(20)),
                    color = (Color)Enum.GetValues(typeof(Color)).GetValue(rnd.Next(5)),
                    size = (Size)Enum.GetValues(typeof(Size)).GetValue(rnd.Next(3))
                });
            }

            return myCollection.collection;
        }
    }
}
