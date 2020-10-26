using System.ComponentModel.DataAnnotations;

namespace frontendapi_bikeshop.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}