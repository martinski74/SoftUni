using Newtonsoft.Json;
using ProductsShop.Data;
using ProductsShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace ProductsShop.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ProductsShopContext())
            {
                // 1.	Products Shop check DB Models here:  .\Models\*
                //context.Database.Initialize(true);

                // 2.	Import data
                //ImportUsersToDb(context);
                //ImportProductsWithSeller(context);
               //ImportCategories(context);
                //ImportRandomCategoryToRandomProduct(context);

                ////3.	Query and Export Data
                //Query_1_ProductsInRange(context);
                //Query_2_SuccessfullySoldProducts(context);
                //Query_3_CategoriesByProductsCount(context);
                //Query_4_UsersAndProducts(context);

            }
        }

        private static void Query_4_UsersAndProducts(ProductsShopContext context)
        {
            var UsersWithSoldProducts = context.Users.Where(u => u.SoldProducts.Count >= 1).OrderBy(u => u.LastName);

            var UsersAndProducts = UsersWithSoldProducts.Select(c => new
            {
                usersCount = c.SoldProducts.Count,
                users = UsersWithSoldProducts.Select(o => new
                {
                    o.FirstName,
                    o.LastName,
                    o.Age,
                    SoldProducts = o.SoldProducts.Select(p => new
                    {
                        o.SoldProducts.Count,
                        SoldProducts = o.SoldProducts.Select(r => new
                        {
                            r.Name,
                            r.Price
                        })
                    })
                })
            }).OrderByDescending(u => u.usersCount);


            PrintJson(UsersAndProducts);
        }

        private static void Query_3_CategoriesByProductsCount(ProductsShopContext context)
        {
            var categoriesByProductsCount =
                context.Categories.Select(c => new
                {
                    category = c.Name,
                    productsCount = c.Products.Count,
                    averagePrice = c.Products.Average(p => p.Price),
                    totalRevenue = c.Products.Count * c.Products.Average(p => p.Price)
                }).OrderBy(c => c.category);

            PrintJson(categoriesByProductsCount);
        }

        private static void Query_2_SuccessfullySoldProducts(ProductsShopContext context)
        {
            var successfullySoldProducts =
                context.Users.Where(u => u.SoldProducts.Count >= 1).Select(x => new { x.FirstName, x.LastName, x.SoldProducts }).Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Products = x.SoldProducts.Select(p => new
                    {
                        p.Name,
                        p.Price,
                        p.Seller.FirstName,
                        p.Seller.LastName
                    })
                });

            PrintJson(successfullySoldProducts);
        }

        private static void PrintJson(IQueryable json)
        {
            string result = JsonConvert.SerializeObject(json, Newtonsoft.Json.Formatting.Indented);

            Console.WriteLine(result);
        }

        private static void Query_1_ProductsInRange(ProductsShopContext context)
        {
            var productsInRange = context.Products.Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(
                    x => new
                    {
                        Name = x.Name,
                        Price = x.Price,
                        SellerName = x.Seller.FirstName + "" + x.Seller.LastName
                    });


            PrintJson(productsInRange);
        }

        private static void ImportRandomCategoryToRandomProduct(ProductsShopContext context)
        {
            var products = context.Products.ToList();
            var categories = context.Categories.ToList();
            int randomizer = 2;
            foreach (var category in categories)
            {
                foreach (var product in products)
                {
                    if ((randomizer + 1) % 4 == 0)
                    {
                        product.Categories.Add(category);
                        randomizer++;
                    }
                    randomizer++;
                }
            }
            context.SaveChanges();
        }

        private static void ImportCategories(ProductsShopContext context)
        {
            Console.WriteLine("Importing categories..");

            string jsnoFile = File.ReadAllText(@"..\..\Import\categories.json");
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(jsnoFile);

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }

        private static void ImportProductsWithSeller(ProductsShopContext context)
        {
            Console.WriteLine("Importing products..");

            string jsnoFile = File.ReadAllText(@"..\..\Import\products.json");
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(jsnoFile);

            int randomSeller = 33;
            int userCount = context.Users.Count();
            foreach (var product in products)
            {
                product.SellerId = randomSeller % userCount;
                randomSeller++;

                if (randomSeller % 5 != 0)
                {
                    product.BuyerId = randomSeller * 12 % userCount;
                }
            }

            context.Products.AddRange(products);
            context.SaveChanges();
        }

        private static void ImportUsersToDb(ProductsShopContext context)
        {
            Console.WriteLine("Importing users..");

            string jsnoFile = File.ReadAllText(@"..\..\Import\users.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsnoFile);

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}

