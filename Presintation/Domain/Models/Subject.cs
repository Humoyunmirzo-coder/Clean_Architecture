﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class Subject
    {
        public int SubjectId {  get; set; }
        public required string SubjectName { get; set; }
        public override string ToString()
        {
            return $"SubjectId: {SubjectId} \n SubjectName: {SubjectName}"; 
        }

    }
}
