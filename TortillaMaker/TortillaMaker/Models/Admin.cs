using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TortillaMaker.Models
{
    [Table("Admin")]
    public class Admin
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
