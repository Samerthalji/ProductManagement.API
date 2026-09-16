using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace FirstProject
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Modules.User>().HasData(
                new Modules.User
                {
                    Id = 1,
                    UserName = "Samer",
                    PasswordHash = "$2a$11$q9y.q.X1sO9.0LgHk1K / Ju.W5q94I6P.J1yO / 98hX2W / Q99J024dG",
                    Email = "samer@example.com",
                    Role = "Admin"
                });
        }
        public DbSet<Modules.User> Users { get; set; }
        public DbSet<Modules.Product> Products { get; set; }

    }
}
