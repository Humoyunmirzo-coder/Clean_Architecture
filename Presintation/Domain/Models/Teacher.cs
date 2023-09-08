using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class Teacher : Person 
    {
        public int TeacherId { get; set; }
        public override string ToString()
        {
            return $" TeacherId: {TeacherId} \n FullName: {FullName} \n BirthDate: {Birthday} \n Gender: {Gender}";
        }
    }
}
