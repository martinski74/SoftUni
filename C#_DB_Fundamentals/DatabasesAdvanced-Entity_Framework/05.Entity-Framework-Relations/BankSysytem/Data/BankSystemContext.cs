namespace BankSysytem.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BankSystemContext : DbContext
    {

        public BankSystemContext()
            : base("name=BankSystemContext")
        {
        }


        public virtual DbSet<CheckingAccount> CheckingAccounts { get; set; }

        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Checking Account
            // Set primary key.
            modelBuilder.Entity<CheckingAccount>().HasKey(a => a.Id);

            // Set required properties.
            modelBuilder.Entity<CheckingAccount>().Property(a => a.AccountNumber).IsRequired();
            modelBuilder.Entity<CheckingAccount>().HasRequired(a => a.User).WithMany(u => u.CheckingAccounts);

            // Set unique.
            modelBuilder.Entity<CheckingAccount>().Property(a => a.AccountNumber)
                .HasColumnAnnotation("IX_SavingAccounts_AccountNumber", new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            // Saving Account
            // Set primary key.
            modelBuilder.Entity<SavingAccount>().HasKey(a => a.Id);

            // Set required properties.
            modelBuilder.Entity<SavingAccount>().Property(a => a.AccountNumber).IsRequired();
            modelBuilder.Entity<SavingAccount>().HasRequired(a => a.User).WithMany(u => u.SavingAccounts);

            // Set unique.
            modelBuilder.Entity<SavingAccount>().Property(a => a.AccountNumber).HasColumnAnnotation("IX_SavingAccounts_Username", new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            // User
            // Set primary key.
            modelBuilder.Entity<User>().HasKey(u => u.Id);

            // Set fields as required.
            modelBuilder.Entity<User>().Property(u => u.Username).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();

            // Set fields as unique.
            modelBuilder.Entity<User>().Property(u => u.Username).HasColumnAnnotation("IX_Users_Username", new IndexAnnotation(new IndexAttribute { IsUnique = true }));
            modelBuilder.Entity<User>().Property(u => u.Email).HasColumnAnnotation("IX_Users_Email", new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            base.OnModelCreating(modelBuilder);
        }
    }


}