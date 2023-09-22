using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreOneToOne
{
    internal  class Adress : DbContext
    {
        public Adress()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server = ::1 ; Port = 5432; Database = Studentt; User Id = postgres; password = 2244");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet <StudentAddress> StudentAddresses { get; set; }

    }
   
}
