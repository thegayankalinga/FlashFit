using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Exceptions;

[Serializable]
public class InvalidUserException : Exception
{

        public InvalidUserException() { }

        public InvalidUserException(string message) : base(message)
        {
        }

}
