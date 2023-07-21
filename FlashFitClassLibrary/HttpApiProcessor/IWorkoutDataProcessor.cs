using FlashFitClassLibrary.Resources.CheatmealRecord;
using FlashFitClassLibrary.Resources.WorkoutRecord;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.HttpApiProcessor
{
    public interface IWorkoutDataProcessor
    {
        //From API Gateway



        //From Internal Services
        [Get(path: "/workoutrecord/byuser/{email}")]
        Task<ApiResponse<IEnumerable<WorkoutRecordResponse>>> GetInternalWorkoutRecordHistoryForUser(string email);
    }
}
