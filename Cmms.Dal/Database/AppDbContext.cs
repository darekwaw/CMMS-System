using Cmms.Data.Models;
using System.Data.Entity;

namespace Cmms.Dal.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("CmmsDbConectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ReportDefinition> ReportDefinitions { get; set; }
    }
}
