using System.ComponentModel.DataAnnotations;

namespace AuthAPI903.Dtos
{
    public class ForgotPasswordDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
