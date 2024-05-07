using Microsoft.EntityFrameworkCore;
using TaskOneMVC.Models;

namespace TaskOneMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=TaskOneMVC;trusted_connection=True;trustServerCertificate=True");
        }
    }
}
