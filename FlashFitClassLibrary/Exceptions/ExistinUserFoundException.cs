using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Exceptions
{
    [Serializable]
    public class ExistinUserFoundException : Exception
    {
        public ExistinUserFoundException() { }

        public ExistinUserFoundException(string? message) : base(message)
        {
        }
    }
}
