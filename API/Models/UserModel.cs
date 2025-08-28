using Microsoft.AspNetCore.Identity;

namespace API.Models
{
    public class UserModel : IdentityUser
    {
        public string? FullName { get; set; }
    }
}