using Microsoft.EntityFrameworkCore;
namespace AngularWebApp.Data
{
    public class EmployeesContext : DbContext
    {
         public EmployeesContext (DbContextOptions<EmployeesContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Employee> Employee { get; set; }
    }
}