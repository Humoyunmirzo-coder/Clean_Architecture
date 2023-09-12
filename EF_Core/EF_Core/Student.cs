using System;
using System.Collections.Generic;

namespace EFCoreTutorials.Models
{
    public partial class Student
    {


        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? StandardId { get; set; }
        public string Name { get; internal set; }
    }
      
}