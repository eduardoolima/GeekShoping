using Microsoft.AspNetCore.Identity;

namespace GeekShopping.IdentityServer.Model
{
    public class ApplicationUser : IdentityUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
