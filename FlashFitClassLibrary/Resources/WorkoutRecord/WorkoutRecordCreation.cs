namespace FlashFitClassLibrary.Resources.WorkoutRecord;

public sealed record WorkoutRecordCreation(
       int WorkoutTypeId,
       string UserEmail,
       DateTime WorkoutDateTime,
       decimal WeightAtCompletion,
       DateTime CreatedDate
    )
{
}
