using EmployeeDetailsFrameWork.entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetailsFrameWork
{
    public class Context : DbContext
    { public DbSet<Employee> Employees {get;set;}
        public DbSet<EmployeeOrganization> Organization{get;set;}
        public Context() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-2D3FN7GQ;Database=Employeeorganization;Trusted_Connection=True;");

        }
    }
}
