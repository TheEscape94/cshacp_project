using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class TokenException : Exception
    {
        public TokenException()
        {
            
        }
        public TokenException(string msg) : base(msg) 
        {
        
        }
    }

}
