using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TortillaMaker.Models
{
    public class Menu
    {
        public int? Id { get; set; }
        public enum Type { Flour, Wheat, Corn, FlourCorn }
        public Type TortillaType { get; set; }
    }
}
