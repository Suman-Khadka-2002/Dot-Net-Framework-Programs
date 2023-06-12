using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkProj.EntityData
{
    public class EntityDB : DbContext
    {
        public EntityDB(DbContextOptions<EntityDB> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
