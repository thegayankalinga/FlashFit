using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Resources.Cheatmeal
{
    public sealed record CheatmealTypeUpdate(
            int Id,
            string Name,
            decimal CheatmealCaloryGain,
            DateTime DateUpdated
        )
    {
    }
}
