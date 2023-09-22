using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ManiyAdnOne
{
    public class SchoolContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server = ::1 ; Port = 5432; Database = school; User Id = postgres; password = 2244");
        }

   

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
   
    }
}
