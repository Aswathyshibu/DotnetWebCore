using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcore.Models
{
    public class EmployeeContext:DbContext
    {
       
        public EmployeeContext(DbContextOptions<EmployeeContext>options):base(options)
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
       // public IEnumerable<EmployeeDto> sp_GetEmployees { get; set; } 
      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        */
    }
}
