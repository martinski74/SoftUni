using HaspitalDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDBModification.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.Visitations = new List<Visitation>();
        }
        // doctors (name and specialty)
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DoctorId { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }


        [Required]
        [StringLength(120)]
        public string Specialty { get; set; }

        public virtual List<Visitation> Visitations { get; set; }

    }
}
