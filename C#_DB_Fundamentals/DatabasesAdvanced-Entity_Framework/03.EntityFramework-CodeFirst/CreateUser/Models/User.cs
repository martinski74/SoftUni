using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateUser
{
    public class User
    {
        private string username;
        private string password;
        public int Id { get; set; }
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                if (value.Length < 4 || value.Length > 30)
                    throw new ArgumentOutOfRangeException(
                    "The username should be between " +
                    "4 and 30 symbols.");
                this.username = value;
            }
        }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,50}$")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(8388608)]
        public byte[] ProfilePicture { get; set; }

        public DateTime? RegisteredOn { get; set; }

        public DateTime? LastTimeLoggedIn { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }

        public bool IsDeleted { get; set; }
    }
}
