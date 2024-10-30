using Microsoft.EntityFrameworkCore;
using GestorTareas.Models;

namespace GestorTareas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        { 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserTask> UserTask { get; set; }
    }
}
