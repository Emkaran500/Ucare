using Microsoft.AspNetCore.Identity;

namespace UcareApp.Presentation.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
    }
}