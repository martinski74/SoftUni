using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsShop.Models
{
    public class User
    {

        public User()
        {
            this.SoldProducts = new List<Product>();
            this.Products = new List<Product>();
            this.Friends = new List<User>();
        }

        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        public int? Age { get; set; }


        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Product> SoldProducts { get; set; }

        public virtual ICollection<User> Friends { get; set; }

    }
}
