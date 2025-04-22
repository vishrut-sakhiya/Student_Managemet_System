using Microsoft.EntityFrameworkCore;

namespace Student_Managemet_System.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            
        }

        public DbSet<Student> student { get; set; }
    }
}
