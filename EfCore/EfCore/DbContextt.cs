using EfCore.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EfCore;

public class DbContextt : DbContext
{
    public string Connectionstring = "server = localhost ; Port =5432; Database=Hotel; User Id= postgres ; password =2244 ";

    public DbContextt()
    {
        
    }
    public DbContextt(DbContextOptions<DbContext>options):base(options) 
    {
        
    }
    public DbSet<Customers> customers {  get; set; }
    DbSet<OrderDetails> orderDetails {  get; set; }
    DbSet<Property> properties {  get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("server = ::1 ; Port = 5432; Database = hotel; User Id = postgres; password = 2244");
    }


}
