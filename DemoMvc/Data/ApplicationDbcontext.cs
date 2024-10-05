using Microsoft.EntityFrameworkCore;
using DemoMvc.Models;

namespace DemoMvc.Data
{   
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}