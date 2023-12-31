

using Microsoft.EntityFrameworkCore;
using WebApiGrey.Shared;

namespace WebApiGrey.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //configure dbContext option 
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students{ get; set; }
        

    }
}
