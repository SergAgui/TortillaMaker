using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TortillaMaker.Models;

namespace TortillaMaker.Models
{
    public class Context : DbContext
    {
        //public DbSet<User> Users { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<Menu> Menus { get; set; }
        public Context(DbContextOptions<Context> options) :base(options)
        {
        }
    }
}
