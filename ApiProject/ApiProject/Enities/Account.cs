using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProject.Enities
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(200)]
        public string? Name { get; set; } = string.Empty;
        [MaxLength(200)]
        public string? Family { get; set; } = string.Empty;
        [MaxLength(200)]
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        [MaxLength(18)]
        public int? Phone { get; set; }

        public Account(string Email,string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }

    }
}
