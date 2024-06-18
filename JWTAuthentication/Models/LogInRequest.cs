using System.ComponentModel.DataAnnotations;

namespace JWTAuthentication.Models
{
    public class LogInRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
