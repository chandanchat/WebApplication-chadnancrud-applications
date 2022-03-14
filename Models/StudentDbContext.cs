using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class StudentDbContext:DbContext
    { 
        public StudentDbContext(DbContextOptions<StudentDbContext> Options) : base(Options) { }
        public DbSet<Student> students { get; set; }

    }
}
