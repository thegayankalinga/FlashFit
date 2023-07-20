using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
