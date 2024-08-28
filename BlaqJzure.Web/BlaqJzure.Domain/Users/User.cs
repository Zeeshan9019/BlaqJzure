using Microsoft.AspNetCore.Identity;
using BlaqJzure.Common.Enums;

namespace BlaqJzure.Domain.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AppRole Role { get; set; }
    }
}
