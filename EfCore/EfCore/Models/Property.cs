﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Models;

public  class Property
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }

}
