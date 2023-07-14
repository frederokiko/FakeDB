using Microsoft.Build.Framework;

namespace TFNetSecurity.Models
{
    public class UserForm
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
