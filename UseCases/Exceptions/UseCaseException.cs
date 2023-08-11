using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Exceptions
{
    public class UseCaseException:Exception
    {
        public UseCaseException(string message) : base(message) { 
            
        }
    }
}
