using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Resources.CheatmealRecord
{
    public sealed record CheatmealRecordResponse(
        int CheatmealRecordId,
        CheatmealModel Cheatmeal,
        string UserEmail,
        DateTime CheatmealRecordedDateTime,
        decimal WeightAtRecordTime

        )
    {
    }
}
