using Microsoft.AspNetCore.Identity;

namespace DevBase.Entity.Common
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
