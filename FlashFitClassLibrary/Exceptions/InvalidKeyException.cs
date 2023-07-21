using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Exceptions
{
    [Serializable]
    public class InvalidKeyException: Exception
    {
        public InvalidKeyException() { }

        public InvalidKeyException(string? message) : base(message)
        {
        }
    }

}
