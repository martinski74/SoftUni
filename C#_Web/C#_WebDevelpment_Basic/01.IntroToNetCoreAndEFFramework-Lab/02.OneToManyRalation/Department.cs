using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Department
{
    //public Department()
    //{
    //    this.Employees = new List<Employee>();
    //}
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public ICollection<Employee> Employees { get; set; } = new List<Employee>();

}

