using cs_finalproject.Model;
using Microsoft.EntityFrameworkCore;

namespace cs_finalproject.Data
{
    public class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=USER-PC\MSSQLSERVER01;Database=Library;Integrated Security=True");
        }


        public DbSet <Books> Books{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public  DbSet<Maneger> Manegers{ get; set; }
        public DbSet<Report> Report { get; set; }
        public int ReportId { get; set; }
        public DbSet<ReportBooks> ReportBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReportBooks>()
                            .HasKey(bc => new { bc.BookId, bc.ReportId });
            modelBuilder.Entity<ReportBooks>()
                            .HasOne(bc => bc.Book)
                                .WithMany(b => b.ReportBooks)
                                    .HasForeignKey(bc => bc.BookId);
            modelBuilder.Entity<ReportBooks>()
                            .HasOne(bc => bc.Report)
                                .WithMany(c => c.ReportBooks)
                                    .HasForeignKey(bc => bc.ReportId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
