using ApiStudent.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiStudent.Models
{
    public class StudentContext : DbContext
    {
        

        // Deklaracje zbiorów danych DbSet<T> i konfiguracje modelu
        // ...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfiguracje modelu
            // ...

            base.OnModelCreating(modelBuilder);
        }
        public class StudentDbContext : IdentityDbContext<UserEntity,UserRole, int>
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
