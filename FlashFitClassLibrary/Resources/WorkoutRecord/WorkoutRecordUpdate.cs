namespace FlashFitClassLibrary.Resources.WorkoutRecord;

public sealed record WorkoutRecordUpdate(
    int WorkoutRecordId,
   int WorkoutTypeId,
   string UserEmail,
   DateTime WorkoutDateTime,
   decimal WeightAtCompletion,
   DateTime UpdateDate

    )
{
}
