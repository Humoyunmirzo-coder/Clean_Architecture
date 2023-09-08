using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class Grade
    {
        public int GradeId { get; set; }
        public GradeEnum GradeEnum { get; set; }
        public DateTime Date {  get; set; }
        public override string ToString()
        {
            return $" Grade Id = {GradeId} \n Grade Type {GradeEnum} \n DataTime {Date} ";
        }
    }
}
