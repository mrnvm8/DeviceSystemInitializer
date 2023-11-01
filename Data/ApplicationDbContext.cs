using DeviceSystemInitializer.Model;
using Microsoft.EntityFrameworkCore;

namespace DeviceSystemInitializer.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=user1;password=xxxxxx;database=SystemDB");
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Office> Offices => Set<Office>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Person> People => Set<Person>();
        public DbSet<Employee> Employees => Set<Employee>();
    }


}
