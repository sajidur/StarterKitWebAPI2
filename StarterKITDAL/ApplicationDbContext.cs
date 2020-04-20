using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext():base("name=AppConnectionString")
        {
            Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rules>().HasRequired(a => a.SalaryItem).WithMany().HasForeignKey(a=>a.SalaryItemId);
        }
        //entities
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<SalaryItem> SalaryItems { get; set; }
        public DbSet<Rules> Rules { get; set; }
        public DbSet<Conditions> Conditions { get; set; }

    }
    public class SeedInitialize : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
        }
    }
}
