using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthorizationAuthentication.Data
{
    public class EntityDB : IdentityDbContext
    {
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public EntityDB(DbContextOptions options) : base(options) { }
    }
}
