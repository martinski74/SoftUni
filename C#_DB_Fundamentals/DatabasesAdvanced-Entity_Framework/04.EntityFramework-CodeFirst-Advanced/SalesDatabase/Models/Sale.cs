
using System;

namespace SalesDatabase
{
    public class Sale
    {
        public int Id { get; set; }
        public Product Products { get; set; }
        public Customer Customers { get; set; }
        public StoreLocation StoreLocation { get; set; }
        public DateTime Date { get; set; }
    }
}
