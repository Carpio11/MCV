using _2021.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace _2021.DAL
{
    public class ExpContext : DbContext
    {
        public DbSet<Pessoal> Students { get; set; }
        public DbSet<InfoExp> Enrollments { get; set; }
        public DbSet<Exp> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}