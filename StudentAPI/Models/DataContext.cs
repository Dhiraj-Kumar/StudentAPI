using Microsoft.EntityFrameworkCore;
namespace StudentAPI.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Student> Students { get; set; } = null!;
    }
}
