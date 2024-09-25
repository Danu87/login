using login.Models;
using Microsoft.EntityFrameworkCore;

namespace login.Controllers.Data
{
    public class ApplicationContext : DbContext  // Use 'DbContext' instead of 'DbContect'
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
