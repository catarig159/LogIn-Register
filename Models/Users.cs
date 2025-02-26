using Microsoft.AspNetCore.Identity;

namespace UsersApp.Models
{
    public class Users : IdentityUser
    {
        public string? FullName { get; set; } // Ensure FullName is nullable
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
    }
}
