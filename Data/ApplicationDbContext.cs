using Microsoft.EntityFrameworkCore;
using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Worker> Workers { get; set; } 
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Supervisor> Supervisors { get; set; } 
        public DbSet<Manager> Managers { get; set; } 
    }
}
