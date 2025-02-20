using Cmms.Data.Models;
using System.Data.Entity;

namespace Cmms.Dal.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("CmmsDbConectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReportDefinition>()
                .HasIndex(r => r.Name)
                .IsUnique();    // Unikalna nazwa raportu

            modelBuilder.Entity<ReportDefinition>()
                .Property(r => r.XmlContent)
                .HasColumnType("nvarchar(max)");

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ReportDefinition> ReportDefinitions { get; set; }
    }
}
