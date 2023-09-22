using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreMangAndMany
{
    public class Student11
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }

        public IList<Course> Students11 { get; set; }
    }
}
