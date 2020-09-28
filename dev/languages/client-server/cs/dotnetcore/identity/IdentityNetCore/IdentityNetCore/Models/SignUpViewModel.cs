using System.ComponentModel.DataAnnotations;

namespace IdentityNetCore.Models
{
    public class SignUpViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Missing or invalid e-mail.")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Missing or invalid password.")]
        public string Password { get; set; }
    }
}
