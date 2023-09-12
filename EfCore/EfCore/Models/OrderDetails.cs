using System.ComponentModel.DataAnnotations;

namespace EfCore.Models;

public class OrderDetails
{
    [Key]
    public int Id { get; set; }
    public int MyProperty { get; set; }
    public int MyProperty1122 { get; set; }
}