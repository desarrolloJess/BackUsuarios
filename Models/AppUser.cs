using Microsoft.AspNetCore.Identity;

namespace AuthAPI903.Models
{
    public class AppUser :IdentityUser
    {
        public string? FullName { get; set; }  

    }
}
