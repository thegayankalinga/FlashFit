using FlashFitClassLibrary.Models;

namespace FlashFitClassLibrary.Resources.CheatmealRecord
{
    public sealed record CheatmealRecordResponse(
        int CheatmealRecordId,
        CheatmealModel Cheatmeal,
        string UserEmail,
        DateTime CheatmealAddedDateTime,
        decimal WeightAtRecordTime

        )
    {
    }
}
