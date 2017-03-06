using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaspitalDatabase.Models
{
    public class Patient
    {
        public Patient()
        {
            this.Visitations = new List<Visitation>();
            this.Diagnoses = new List<Diagnose>();
            this.Medicaments = new List<Medicament>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        public string Address { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public byte[] Picture { get; set; }

        [Required]
        public bool HasInsurance { get; set; }

        public virtual List<Visitation> Visitations { get; set; }

        public virtual List<Diagnose> Diagnoses { get; set; }

        public virtual List<Medicament> Medicaments { get; set; }

    }
}
