namespace Gringotts
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Models;

    public class GringottsContext : DbContext
    {
       
        public GringottsContext()
            : base("name=GringottsContext")
        {
            Database.SetInitializer(new
                DropCreateDatabaseIfModelChanges<GringottsContext>());
        }

         public virtual DbSet<WizardDeposits> Deposits { get; set; }
    }
}