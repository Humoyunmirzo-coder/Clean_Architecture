using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class Person
    {
        public required string FullName { get; set; }
        public DateTime Birthday { get; set; }
      
        public bool Gender { get; set; }
        public string Phone {  get; set; }
    }
}
