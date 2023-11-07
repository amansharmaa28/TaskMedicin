using Microsoft.EntityFrameworkCore;
using TaskMedicin.Models;
using System.Collections.Generic;

namespace TaskMedicin.Data
{
    public class TaskDbContext : DbContext
    {
       
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }
        
        public DbSet<Medicin> Medicins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Doctors> Doctors { get; set; }

        public DbSet<Catg> Category { get; set; }

    }
}
