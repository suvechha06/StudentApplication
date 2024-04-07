using Microsoft.EntityFrameworkCore;

namespace StudentCRUD.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get;set; }
    }
}
