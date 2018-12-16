using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TortillaMaker.Models
{
    public class Repository
    {
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
