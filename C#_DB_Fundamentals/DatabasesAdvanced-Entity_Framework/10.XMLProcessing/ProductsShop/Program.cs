namespace ProductsShop
{
    using System.Linq;
    using System.Xml.Linq;

    using Data;

    using Model;
    using Methods;

    public class Application
    {
        public static void Main(string[] args)
        {
            ProductShopContext context = new ProductShopContext();
            //context.Database.Initialize(true);

            XMLMethods.SeedData(context);
            XMLMethods.ExportData(context);
        }
    }
}
