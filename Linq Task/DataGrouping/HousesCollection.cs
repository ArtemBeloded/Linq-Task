using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrouping
{
    public class HousesCollection
    {
        public List<House> collection { get; set; }
        public HousesCollection()
        {
            collection = new List<House>();
        }
    }
}
