using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp
{
    public class MaximumMoviesException : Exception
    {
        public MaximumMoviesException(string message) : base(message) 
        {
            
        }
    }
}
