using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TeacherProject.Models;

namespace TeacherProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
      public DbSet<Employee> Employee { get;set; }
      public DbSet<Calender> Calender { get;set; }
      public DbSet<EmployeeTotalSalary> EmployeeTotalSalary { get; set; }

    }
}
