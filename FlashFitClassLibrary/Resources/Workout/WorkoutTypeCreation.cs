using FlashFitClassLibrary.Enumz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
