using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
