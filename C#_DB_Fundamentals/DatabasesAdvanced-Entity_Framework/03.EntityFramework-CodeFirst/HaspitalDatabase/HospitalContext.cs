namespace HaspitalDatabase
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Models;

    public class HospitalContext : DbContext
    {
        // Your context has been configured to use a 'HospitalContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'HaspitalDatabase.HospitalContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HospitalContext' 
        // connection string in the application configuration file.
        public HospitalContext()
            : base("name=HospitalContext")
        {
        }



        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Visitation> Visitations { get; set; }
        public virtual DbSet<Diagnose> Diagnoses { get; set; }
        public virtual DbSet<Medicament> Medicaments { get; set; }
    }

    
}