using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Resources.CheatmealRecord
{
    public sealed record CheatmealRecordCreation(
        int CheatmealId,
        string UserEmail,
        decimal WeightAtRecordTime, 
        DateTime CheatmealRecordedDateTime,
        DateTime CheatmealAddedDateTime
        )
    {
    }
}
