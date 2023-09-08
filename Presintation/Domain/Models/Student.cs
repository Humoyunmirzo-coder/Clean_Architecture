using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class Student : Person
    {
        public int StudentId { get; set; }
        public override string ToString() 
        {
            return $" StudentId: {StudentId} \n  FullName: {FullName} \n BirthData: {Birthday} \n Gender: {Gender}  ";
        }
    }
}
