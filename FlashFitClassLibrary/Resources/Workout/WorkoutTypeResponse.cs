using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
