using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Resources.User
{
    public sealed record UserUpdateWeight(
            string Email,
            decimal WeightInKiloGrams
        )
    {
    }
}
