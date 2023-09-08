using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class StudentTEacher
    {
        public int Id { get; set; }
         public required Student student { get; set; }
        public required Teacher Teacher { get; set; }
        public required Subject Subject { get; set; }
        public override string ToString()
        {
            return $" Id: {Id} \n Student: {student} \n Teacher: {Teacher} \n Subject: {Subject} ";
             
        }
    }
}
