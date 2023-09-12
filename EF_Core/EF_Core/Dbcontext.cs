using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreTutorials.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    public  class Dbcontext :DbContext
    {
        public Dbcontext()
        {
            
        }
        public Dbcontext(DbContextOptions<Dbcontext> Class) : base(Class)
        {

        }
        public DbSet <Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server = localhost ; Port =5432; Database=Studentt; User Id= postgres ; password =2244 ");
        }

    }
}
