using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Resources.CheatmealRecord
{
    public sealed record CheatmealReocrdUpdate(
        int CheatmealRecordId,
        int CheatmealId,
        string UserEmail,
        DateTime CheatmealRecordedDateTime,
        decimal WeightAtRecordTime,
        DateTime CheatmealUpdatedDateTime
        )
    {
    }
}
