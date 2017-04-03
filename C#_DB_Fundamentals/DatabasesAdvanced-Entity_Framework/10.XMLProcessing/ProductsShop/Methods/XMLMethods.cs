using ProductsShop.Data;
using ProductsShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductsShop.Methods
{
    public static class XMLMethods
    {
        public static void SeedData(ProductShopContext ctx)
        {
            SeedUsers(ctx);
            SeedProducts(ctx);
            SeedCategories(ctx);
        }

        public static void ExportData(ProductShopContext ctx)
        {
            ExportUsersAndProducts(ctx);
            ExportCategoriesByProductsCount(ctx);
            ExportUsersWithSells(ctx);
            ExportProductsInRangeToXML(ctx);
        }

        private static void ExportUsersAndProducts(ProductShopContext ctx)
        {
            ICollection<XElement> elements = new List<XElement>();
            var users = ctx.Users.Where(u => u.ProductsSold.Count > 0);

            users.OrderByDescending(u => u.ProductsSold.Count)
                .ThenBy(u => u.LastName)
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    soldProducts = new
                    {
                        count = u.ProductsSold.Count(),
                        products = u.ProductsSold.Select(p => new
                        {
                            name = p.Name,
                            price = p.Price,
                        })
                    }
                }).ToList().ForEach(u =>
                {
                    XElement element = new XElement("user",
                            new XAttribute("first-name", u.firstName ?? ""),
                            new XAttribute("last-name", u.lastName),
                            new XAttribute("age", u.age),
                            new XElement("sold-products", new XAttribute("count", u.soldProducts.count)));
                    if (int.Parse(element.Attribute("age").Value) == 0)
                    {
                        element.Attribute("age").Remove();
                    }
                    if (element.Attribute("first-name").Value == string.Empty)
                    {
                        element.Attribute("first-name").Remove();
                    }
                    u.soldProducts.products.ToList().ForEach(p =>
                    {
                        element.Element("sold-products").Add(
                            new XElement("product",
                               new XAttribute("name", p.name),
                               new XAttribute("price", p.price))
                        );
                    });
                    elements.Add(element);
                });
            XDocument doc = new XDocument();
            doc.Add(new XElement("users", new XAttribute("count", users.Count()), elements));
            doc.Save("../../../Export-XML/users-and-products.xml");
        }

        private static void ExportCategoriesByProductsCount(ProductShopContext ctx)
        {
            ICollection<XElement> elements = new List<XElement>();
            ctx.Categories.OrderBy(c => c.Products.Count())
                    .Select(c => new
                    {
                        name = c.Name,
                        productsCount = c.Products.Count(),
                        averagePrice = c.Products.Average(p => p.Price),
                        totalRevenue = c.Products.Sum(p => p.Price)
                    }).ToList().ForEach(c =>
                    {
                        elements.Add(new XElement("category",
                                new XAttribute("name", c.name),
                                new XElement("products-count", c.productsCount),
                                new XElement("average-price", c.averagePrice),
                                new XElement("total-revenue", c.totalRevenue)));
                    });
            XDocument doc = new XDocument();
            doc.Add(new XElement("categories", elements));
            doc.Save("../../../Export-XML/categories-by-products.xml");
        }

        private static void ExportUsersWithSells(ProductShopContext ctx)
        {
            ICollection<XElement> elements = new List<XElement>();

            ctx.Users.Where(u => u.ProductsSold.Count() > 0)
                    .OrderBy(u => u.LastName)
                    .ThenBy(u => u.FirstName)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        soldProducts = u.ProductsSold.Select(p => new
                        {
                            name = p.Name,
                            price = p.Price,
                        })
                    }).ToList().ForEach(u =>
                    {
                        XElement element = new XElement("user",
                                               new XAttribute("first-name", u.firstName ?? ""),
                                               new XAttribute("last-name", u.lastName),
                                               new XElement("sold-products"));
                        u.soldProducts.ToList().ForEach(p =>
                        {
                            element.Element("sold-products").Add(
                                new XElement("product",
                                   new XElement("name", p.name),
                                   new XElement("price", p.price))
                            );
                        });
                        elements.Add(element);

                    });
            XDocument doc = new XDocument();

            doc.Add(new XElement("users", elements));
            doc.Save("../../../Export-XML/users-sold-products.xml");
        }

        private static void ExportProductsInRangeToXML(ProductShopContext ctx)
        {
            ICollection<XElement> elements = new List<XElement>();
            ctx.Products.Where(p => p.Price >= 1000 && p.Price <= 2000 && p.Buyer != null)
                    .Select(p => new
                    {
                        p.Name,
                        p.Price,
                        BuyerName = (p.Buyer.FirstName ?? "") + " " + p.Buyer.LastName
                    })
                    .OrderBy(p => p.Price).ToList().ForEach(p =>
                    {
                        elements.Add(new XElement("product",
                                new XAttribute("name", p.Name),
                                new XAttribute("price", p.Price),
                                new XAttribute("buyer", p.BuyerName)));
                    });
            XDocument doc = new XDocument();
            doc.Add(new XElement("products", elements));
            doc.Save("../../../Export-XML/products-in-range.xml");
        }

        private static void SeedCategories(ProductShopContext ctx)
        {
            XDocument xmlData = XDocument.Load("../../../Import-XML-Resources/categories.xml");

            ICollection<Category> categories = new HashSet<Category>();
            Random rand = new Random();
            int productsCount = ctx.Products.Count();
            var products = ctx.Products;
            xmlData.Root.Elements().ToList().ForEach(p =>
            {
                string name = p.Element("name").Value;
                Category category = new Category
                {
                    Name = name
                };
                for (int i = 0; i < productsCount / 3; i++)
                {
                    Product product = products.Find(rand.Next(1, productsCount + 1));
                    category.Products.Add(product);
                }
                categories.Add(category);
            });
            ctx.Categories.AddRange(categories);
            ctx.SaveChanges();

        }

        private static void SeedProducts(ProductShopContext ctx)
        {
            XDocument xmlData = XDocument.Load("../../../Import-XML-Resources/products.xml");

            ICollection<Product> products = new HashSet<Product>();
            Random rand = new Random();
            int usersCount = ctx.Users.Count();

            xmlData.Root.Elements().ToList().ForEach(p =>
            {
                string name = p.Element("name").Value;
                decimal price = decimal.Parse(p.Element("price").Value);
                Product product = new Product
                {
                    Name = name,
                    Price = price,
                };

                double shouldHaveBuyer = rand.NextDouble();
                product.SelledId = rand.Next(1, usersCount + 1);
                if (shouldHaveBuyer <= 0.9)
                {
                    product.BuyerId = rand.Next(1, usersCount + 1);
                }
                products.Add(product);
            });
            ctx.Products.AddRange(products);
            ctx.SaveChanges();
        }

        private static void SeedUsers(ProductShopContext ctx)
        {
            XDocument xmlData = XDocument.Load("../../../Import-XML-Resources/users.xml");

            ICollection<User> users = new HashSet<User>();
            xmlData.Root.Elements().ToList().ForEach(u =>
            {
                string firstName = u.Attribute("first-name")?.Value;
                string lastName = u.Attribute("last-name")?.Value;
                int age = (u.Attribute("age") != null) ? Convert.ToInt32(u.Attribute("age").Value) : 0;
                users.Add(new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                });
            });
            ctx.Users.AddRange(users);
            ctx.SaveChanges();
        }
    }
}

