﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TortillaMaker.Models
{
    [Table("User")]
    public class User
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastInitialS { get; set; }
    }
}
