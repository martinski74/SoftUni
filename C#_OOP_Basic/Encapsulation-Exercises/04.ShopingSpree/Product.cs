
using System;

namespace _04.ShopingSpree
{
    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }
                this.price = value;
            }
        }
    }
}
