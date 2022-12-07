using Microsoft.EntityFrameworkCore;

namespace Web.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<DataBase> Tickets { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}