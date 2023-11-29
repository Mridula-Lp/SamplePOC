using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SampleCRUD.DataModel.Data
{
   //  public class ApplicationUserRole : IdentityUserRole { }

    public class ApplicationRole : IdentityRole {
        public ApplicationRole() : base()
        { }
        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }

    //public class ApplicationUserClaim : IdentityUserClaim<string> { }

    //public class ApplicationUserLogin : IdentityUserLogin<string> { }
    [Index(nameof(Email), nameof(PhoneNumber))]
    public class ApplicationUser  : IdentityUser// IdentityUser<Guid>
    {
        public bool IsPasswordChanged { get; set; }
        public bool IsActive { get; set; }
    }
     
}
