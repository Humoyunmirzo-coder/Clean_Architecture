using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Models;

public  class Customers
{
    [Key]
    public int CustomerId { get; set; } 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Customers customers { get; set; }
    public ICollection<OrderDetails> OrderDetails { get; set; }
    public int Id { get; internal set; }

    //  Customers customers = new Customers();  

}
