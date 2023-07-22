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
