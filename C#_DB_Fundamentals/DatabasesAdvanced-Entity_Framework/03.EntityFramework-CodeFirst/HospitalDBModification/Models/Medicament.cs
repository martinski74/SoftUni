using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaspitalDatabase.Models
{
    public class Medicament
    {
        public Medicament()
        {
            this.Patients = new List<Patient>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        public virtual List<Patient> Patients { get; set; }
    }
}
