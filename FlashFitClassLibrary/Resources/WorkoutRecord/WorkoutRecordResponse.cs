using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
