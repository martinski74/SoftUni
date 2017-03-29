namespace ProductsShop.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductsShopContext : DbContext
    {

        public ProductsShopContext()
            : base("name=ProductsShopContext")
        {
        }



        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.SoldProducts)
                .WithRequired(p => p.Seller);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Products)
                .WithOptional(p => p.Buyer);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Friends)
                .WithMany().Map(mc =>
                {
                    mc.MapLeftKey("UserId");
                    mc.MapRightKey("FriendId");
                    mc.ToTable("UserFriends");
                });

            base.OnModelCreating(modelBuilder);
        }
    }


}