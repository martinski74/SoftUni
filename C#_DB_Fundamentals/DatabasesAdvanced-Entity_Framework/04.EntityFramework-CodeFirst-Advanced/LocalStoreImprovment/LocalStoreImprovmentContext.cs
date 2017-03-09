namespace LocalStoreImprovment
{
    using LocalStoreImprovment.Models;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LocalStoreImprovmentContext : DbContext
    {
        
        public LocalStoreImprovmentContext()
            : base("name=LocalStoreImprovmentContext")
        {
        }



        public virtual DbSet<Product> Products { get; set; }
    }

    
}