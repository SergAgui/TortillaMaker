using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TortillaMaker.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Flour { get; set; }
        public string Wheat { get; set; }
        public string Corn { get; set; }
        public string FlourCorn { get; set; }
    }
}
