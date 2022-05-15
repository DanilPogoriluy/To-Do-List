using Microsoft.EntityFrameworkCore;
using To_Do_List.Models;

namespace To_Do_List.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Missions> MissionsOrder { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }
    }
}
