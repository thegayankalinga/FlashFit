namespace FlashFitClassLibrary.Resources.Workout
{
    public sealed record WorkoutTypeCreation(
        string WorkoutName,
        WorkoutTypeEnum WorkoutType,
        decimal CaloryBurnRate,
        DateTime DateCreated
        )
    {
    }
}
