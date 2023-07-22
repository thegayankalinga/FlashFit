using FlashFitClassLibrary.Resources.User;
using FlashFitClassLibrary.Resources.Workout;
using Refit;

namespace FlashFitClassLibrary.HttpApiProcessor;

public interface IUserDataProcessor
{

    //From API Gateway
    [Get(path: "/api/user/{email}")]
    Task<ApiResponse<UserResource>> GetUser(string email);

    [Post(path: "/api/user/register")]
    Task<ApiResponse<UserResource>> RegisterUser([Body] RegisterResource user);

    [Post(path: "/api/user/login")]
    Task<ApiResponse<UserResource>> LoginUser([Body] LoginResource user);

    [Put(path: "/api/user")]
    Task<ApiResponse<UserResource>> UpdateUser([Body] UserResource user);


    //From Internal Services
    [Patch(path: "/user")]
    Task<ApiResponse<UserResource>> UpdateWeightAndHealth([Body] UserUpdateWeight user);

    [Get(path: "/user/{email}")]
    Task<ApiResponse<UserResource>> GetInternalUser(string email);

    [Get(path: "/api/workouttype")]
    Task<ApiResponse<List<WorkoutTypeResponse>>> GetAllWorkoutTypes();
}
