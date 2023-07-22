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
