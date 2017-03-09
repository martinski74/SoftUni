
using System.ComponentModel.DataAnnotations;

namespace LocalStoreImprovment.Models
{
    public class Product
    {
        private string v1;
        private string v2;
        private string v3;
        private int v4;

        public Product()
        {
        }

        public Product(string v1, string v2, string v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Distributor { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public double? Weight { get; set; }
        public double? Quantity { get; set; }
    }
}
