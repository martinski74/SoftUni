
using System.Collections.Generic;

namespace SalesDatabase
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
