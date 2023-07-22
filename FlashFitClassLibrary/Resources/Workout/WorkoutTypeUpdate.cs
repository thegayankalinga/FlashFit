namespace FlashFitClassLibrary.Resources.Workout
{
    public sealed record WorkoutTypeUpdate(
        int workoutId,
        string WorkoutName,
        WorkoutTypeEnum WorkoutType,
        decimal CaloryBurnRate,
        DateTime DateUpdate
        )
    {
    }
}
