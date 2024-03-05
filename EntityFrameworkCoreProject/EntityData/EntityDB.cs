using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreProject.EntityData
{
    public class EntityDB : DbContext
    {
        public EntityDB(DbContextOptions<EntityDB> Options) : base(Options)
        { }
        public DbSet<Student> Student { get; set; }
    }
}