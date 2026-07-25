using Microsoft.AspNetCore.Identity;
using Microsoft.Identity;

namespace AcademiaX.Infrastructure.Identity {
    public class ApplicationUser : IdentityUser<Guid>{
        public string FirstName { get; set; } = string.Empty;

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = string.Empty;

        public string FullName =>
            string.Join(" ",
                new[]
                {
                FirstName,
                MiddleName,
                LastName
                }.Where(x => !string.IsNullOrWhiteSpace(x)));
    }
}
