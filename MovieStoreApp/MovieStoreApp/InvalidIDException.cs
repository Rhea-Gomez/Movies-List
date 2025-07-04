using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp
{
    public class InvalidIDException : Exception
    {
        public InvalidIDException(string message) : base(message)
        {

        }
    }
}
