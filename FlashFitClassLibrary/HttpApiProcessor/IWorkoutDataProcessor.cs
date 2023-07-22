using FlashFitClassLibrary.Resources.Workout;
using FlashFitClassLibrary.Resources.WorkoutRecord;
using Refit;

namespace FlashFitClassLibrary.HttpApiProcessor
{
    public interface IWorkoutDataProcessor
    {
        //From API Gateway -> Workout Types
        [Get(path: "/api/workouttype")]
        Task<ApiResponse<List<WorkoutTypeResponse>>> GetAllWorkoutTypes();

        [Get(path: "/api/workouttype/{id}")]
        Task<ApiResponse<WorkoutTypeResponse>> GetWorkoutTypeById(int id);

        [Post(path: "/api/workouttype")]
        Task<ApiResponse<WorkoutTypeCreation>> CreateNewWorkoutType([Body] WorkoutTypeCreation worktouType);

        [Put(path: "/api/workouttype")]
        Task<ApiResponse<WorkoutTypeResponse>> UpdateWorkoutType([Body] WorkoutTypeUpdate worktouType);

        [Delete(path: "/api/workouttype/{id}")]
        Task<ApiResponse<WorkoutTypeResponse>> DeleteWorkoutById(int id);


        //From API Gateway -> Workout Record
        [Get(path: "/api/workoutrecord/byuser/{email}")]
        Task<ApiResponse<IEnumerable<WorkoutRecordResponse>>> GetAllWorkoutRecordsByEmail(string email);

        [Post(path: "/api/workoutrecord")]
        Task<ApiResponse<WorkoutRecordCreation>> CreateNewWorkoutRecord([Body] WorkoutRecordCreation workoutRecord);

        [Get(path: "/api/workoutrecord/{id}")]
        Task<ApiResponse<WorkoutRecordResponse>> GetWorkoutRecordById(int id);

        [Put(path: "/api/workoutrecord")]
        Task<ApiResponse<WorkoutRecordResponse>> UpdateWorkoutRecord([Body] WorkoutRecordUpdate workoutRecord);

        [Delete(path: "/api/workoutrecord/{id}")]
        Task<ApiResponse<WorkoutRecordResponse>> DeleteWorkoutRecord(int id);

        //From Internal Services
        [Get(path: "/workoutrecord/byuser/{email}")]
        Task<ApiResponse<IEnumerable<WorkoutRecordResponse>>> GetInternalWorkoutRecordHistoryForUser(string email);
    }
}
