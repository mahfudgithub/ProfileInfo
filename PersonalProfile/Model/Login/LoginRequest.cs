using System.ComponentModel.DataAnnotations;

namespace PersonalProfile.Model.Login
{
    public class LoginRequest
    {
        [Required, StringLength(100)]
        public string Username { get; set; }
        [Required, StringLength(50, MinimumLength = 5)]
        public string Password { get; set; }
    }
}
