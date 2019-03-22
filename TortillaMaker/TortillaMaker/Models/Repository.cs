using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TortillaMaker.Models
{
    public class Repository
    {
        //Context
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        //User Methods
        public void NewUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        //Order Methods
        public void NewOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        //Menu Methods



        //Exceptions
        public class InvalidOrderException : Exception
        {
            public InvalidOrderException(string message) : base(message)
            {
            }
        }

        public class InvalidUserException : Exception
        {
            public InvalidUserException(string message) : base(message)
            {
            }
        }

    }
}
