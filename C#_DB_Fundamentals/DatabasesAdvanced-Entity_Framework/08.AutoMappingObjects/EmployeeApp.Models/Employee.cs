using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public Employee()
        {
            this.Subordinates = new HashSet<Employee>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        //02.Advaced mapping
        public bool IsOnHolliday { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> Subordinates { get; set; }
    }
}
