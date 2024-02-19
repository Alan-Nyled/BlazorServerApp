using Microsoft.AspNetCore.Identity;

namespace BlazorServerApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        // Add additional properties here
        public string Team { get; set; }
    }
}
