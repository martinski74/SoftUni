using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_Advance
{
    public class Product
    {
        public Product(string name, string distributor, string description, decimal price)
        {
            this.Name = name;
            this.Distributor = distributor;
            this.Description = description;
            this.Price = price;
        }

        public Product()
        {
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Distributor { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; internal set; }
        public int Weight { get; internal set; }
    }
}
