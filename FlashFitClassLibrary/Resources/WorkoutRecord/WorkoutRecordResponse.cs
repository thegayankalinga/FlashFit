using FlashFitClassLibrary.Models;

namespace FlashFitClassLibrary.Resources.WorkoutRecord
{
    public sealed record WorkoutRecordResponse(

       int WorkoutRecordId,
       WorkoutModel Workout,
       string UserEmail,
       DateTime WorkoutDateTime,
       decimal WeightAtCompletion

        )
    {
    }
}
