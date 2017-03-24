namespace EmployeeApp.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EmployeeCotext : DbContext
    {
        
        public EmployeeCotext()
            : base("name=EmployeeCotext")
        {
        }

      

         public virtual DbSet<Employee> Employees { get; set; }
    }

   
}