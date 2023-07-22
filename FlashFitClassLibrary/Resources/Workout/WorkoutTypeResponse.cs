namespace FlashFitClassLibrary.Resources.Workout
{
    public sealed record WorkoutTypeResponse(
        int workoutId,
        string WorkoutName,
        WorkoutTypeEnum WorkoutType,
        decimal CaloryBurnRate
        )
    {
    }
}
