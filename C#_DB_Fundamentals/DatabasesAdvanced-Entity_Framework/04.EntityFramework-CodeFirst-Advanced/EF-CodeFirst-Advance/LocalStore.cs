using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_Advance
{
    class LocalStore
    {
        static void Main(string[] args)
        {

            using (var context = new ProductsContext())
            {


                Product product1 = new Product()
                {
                    Name = "Milk",
                    Description = "Cow milk from happy cows(not Milka cows)",
                    Distributor = "Penka",
                    Price = 10.00m
                };

                Product product2 = new Product()
                {
                    Name = "Egg",
                    Description = "Chicken egg",
                    Distributor = "Stanka",
                    Price = 1.00m
                };

                Product product3 = new Product()
                {
                    Name = "Green tea",
                    Description = "Dry",
                    Distributor = "Elena",
                    Price = 112.00m
                };

                context.Products.Add(product1);
                context.Products.Add(product2);
                context.Products.Add(product3);

                context.SaveChanges();
            }
        }
    }
}
