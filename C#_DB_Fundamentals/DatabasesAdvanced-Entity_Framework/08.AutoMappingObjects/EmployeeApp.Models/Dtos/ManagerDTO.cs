using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp.Models.Dtos
{
    public class ManagerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<EmployeeDTO> Subordinates { get; set; }

        public int SubordinatesCount { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.FirstName} {this.LastName} | Employees: {this.SubordinatesCount}");

            foreach (var sub in this.Subordinates)
            {
                sb.AppendLine(sub.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
