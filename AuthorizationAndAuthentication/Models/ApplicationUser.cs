using Microsoft.AspNetCore.Identity;

namespace AuthorizationAndAuthentication.Models

{
    public class ApplicationUser : IdentityUser
    {
        // Additional properties related to the user
        public string FullName { get; set; }
        public int Age { get; set; }

        // You can add more properties as needed
    }

}
