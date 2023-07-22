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
