using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
