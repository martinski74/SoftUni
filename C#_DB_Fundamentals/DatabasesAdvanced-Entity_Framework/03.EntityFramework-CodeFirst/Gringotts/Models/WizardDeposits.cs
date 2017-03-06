
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gringotts.Models
{
    public class WizardDeposits
    {
        //	Id – Primary Key(number in range[1, 2^31 - 1].
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //	FirstName – Text field with max length of 50 symbols.
        [StringLength(50)]
        public string FirstName { get; set; }


        //	LastName - Text field with max length of 60 symbols.Required
        [Required]
        [StringLength(60)]
        public string LastName { get; set; }

        //	Notes – Text field with max length of 1000 symbols
        [StringLength(1000)]
        public string Notes { get; set; }

        // Age – Non-negative number. Required
        [Required]
        [Range(1, int.MaxValue)]
        public int Age { get; set; }

        //	MagicWandCreator – Text field with max length of 100 symbols
        [StringLength(100)]
        public string MagicWandCreator { get; set; }

        //	MagicWandSize – Number in range[1, 2^15 - 1] 32767
        [Range(1, 32767)]
        public int MagicWandSize { get; set; }

        //	DepositGroup - Text field with max length of 20 symbols
        [StringLength(20)]
        public string DepositGroup { get; set; }

        //	DepositStartDate – Date and time field
        public DateTime? DepositStartDate { get; set; }

        //	DepositAmount – Floating point number field
        public decimal DepositAmount { get; set; }

        //	DepositInterest - Floating point number field
        public decimal DepositInterest { get; set; }

        //	DepositCharge - Floating point number field
        public decimal DepositCharge { get; set; }

        //	DepositExpirationDate – Date and time field
        public DateTime? DepositExpirationDate { get; set; }

        //	IsDepositExpired – Boolean field
        public bool IsDepositExpired { get; set; }
    }
}
