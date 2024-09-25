using Microsoft.EntityFrameworkCore;

namespace login.Controllers.Data
{
    public class DbContect
    {
        public DbContect(DbContextOptions<ApplicationContext> options)
        {
        }
    }
}