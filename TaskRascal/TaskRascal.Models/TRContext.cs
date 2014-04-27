using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TaskRascal.Models
{
    public class TRContext : DbContext
    {
        public TRContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Chore> Chores{ get; set; }
        public DbSet<Family> Families{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }

}