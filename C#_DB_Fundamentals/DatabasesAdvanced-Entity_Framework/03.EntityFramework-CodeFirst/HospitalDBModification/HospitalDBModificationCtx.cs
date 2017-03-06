namespace HospitalDBModification
{
    using HaspitalDatabase.Models;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HospitalDBModificationCtx : DbContext
    {
        // Your context has been configured to use a 'HospitalDBModificationCtx' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'HospitalDBModification.HospitalDBModificationCtx' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HospitalDBModificationCtx' 
        // connection string in the application configuration file.
        public HospitalDBModificationCtx()
            : base("name=HospitalDBModificationCtx")
        {
        }

       

        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Visitation> Visitations { get; set; }
        public virtual DbSet<Medicament> Medicaments { get; set; }
        public virtual DbSet<Diagnose> Diagnoses { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}