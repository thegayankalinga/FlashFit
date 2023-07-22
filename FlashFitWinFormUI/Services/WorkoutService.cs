using FlashFitClassLibrary.HttpApiProcessor;
using FlashFitClassLibrary.Resources.User;
using FlashFitClassLibrary.Resources.Workout;
using FlashFitClassLibrary.HttpApiProcessor;
using Refit;

namespace FlashFitClassLibrary.Services;

public class WorkoutService
{
    private readonly string _host = Environment.GetEnvironmentVariable("REMOTEAPIGATEWYHOST") ?? "localhost";
    private readonly string _port = Environment.GetEnvironmentVariable("REMOTEAPIGATEWAYPORT") ?? "7205";

    //TODO: Save workout type
    public async Task<WorkoutTypeCreation?> createWorkout(WorkoutTypeCreation workoutTypeCreation)
    {
        var data = RestService.For<IWorkoutDataProcessor>($"https://{_host}:{_port}");
        var response = await data.CreateNewWorkoutType(workoutTypeCreation).ConfigureAwait(false);

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return new WorkoutTypeCreation(
                response.Content.WorkoutName,
                response.Content.WorkoutType,
                response.Content.CaloryBurnRate,
                response.Content.DateCreated
                );
        }
        else
        {
            return null;
        }

    }

    //TODO: Get All workouts 
    public async Task<List<WorkoutTypeResponse>?> getAllWorkouts()
    {
        var data = RestService.For<IWorkoutDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetAllWorkoutTypes().ConfigureAwait(false);
        List<WorkoutTypeResponse>? workoutTypes = new();


        if (response.Content != null)
        {
            foreach (WorkoutTypeResponse item in response.Content)
            {
                workoutTypes.Add(item);
            }
            return workoutTypes;
    }
        else
        {
            return null;
        }

    }

    //Get by ID
    public async Task<WorkoutTypeResponse?> getWorkoutById(int id)
    {
        var data = RestService.For<IWorkoutDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetWorkoutTypeById(id).ConfigureAwait(false);

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return new WorkoutTypeResponse(
                response.Content.workoutId,
                response.Content.WorkoutName,
                response.Content.WorkoutType,
                response.Content.CaloryBurnRate
                );
        }
        else
        {
            return null;
        }


    }

    //TODO: Update workout
    public async Task<WorkoutTypeResponse?> updateWorkoutById(WorkoutTypeUpdate updateModel)
    {
        var data = RestService.For<IWorkoutDataProcessor>($"https://{_host}:{_port}");
        var response = await data.UpdateWorkoutType(updateModel).ConfigureAwait(false);
 

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return new WorkoutTypeResponse(
               response.Content.workoutId,
               response.Content.WorkoutName,
               response.Content.WorkoutType,
               response.Content.CaloryBurnRate
               );
        }
        else
        {
            return null;
        }

    }

    //TODO: Delete workout 
    public async Task<WorkoutTypeResponse?> deleteWorkoutById(int id)
    {
        var data = RestService.For<IWorkoutDataProcessor>($"https://{_host}:{_port}");
        var response = await data.DeleteWorkoutById(id).ConfigureAwait(false);

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return new WorkoutTypeResponse(
               response.Content.workoutId,
               response.Content.WorkoutName,
               response.Content.WorkoutType,
               response.Content.CaloryBurnRate
               );
        }
        else
        {
            return null;
        }
    }

}
