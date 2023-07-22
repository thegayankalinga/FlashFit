using FlashFitClassLibrary.HttpApiProcessor;
using FlashFitClassLibrary.Resources.WorkoutRecord;
using Refit;

namespace FlashFitClassLibrary.Services;

public class WorkoutRecordService
{
    private readonly string _host = Environment.GetEnvironmentVariable("REMOTEAPIGATEWYHOST") ?? "localhost";
    private readonly string _port = Environment.GetEnvironmentVariable("REMOTEAPIGATEWAYPORT") ?? "7205";
    
    
    //Create workout record
    public async Task<WorkoutRecordCreation> createWorkoutRecord(WorkoutRecordCreation workoutRecordCreation)
    {
        var data = RestService.For<IWorkoutDataProcessor>($"https://{_host}:{_port}");
        var response = await data.CreateNewWorkoutRecord(workoutRecordCreation).ConfigureAwait(false);
        WorkoutRecordCreation? workoutReocord = null;

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return workoutReocord = response.Content;
        }
        else
        {
            throw new Exception();

        }
    }

    //Get workout records by email 
    public async Task<List<WorkoutRecordResponse>> getWorkoutRecordsByEmail(string email)
    {
        var data = RestService.For<IWorkoutDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetAllWorkoutRecordsByEmail(email).ConfigureAwait(false);

        List<WorkoutRecordResponse>? workoutRecords = new();

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            foreach (WorkoutRecordResponse item in response.Content)
            {
                workoutRecords.Add(item);
            }
            return workoutRecords;
        }
        else
        {
            throw new Exception();
        }
    }

    //Get workout record by ID
    public async Task<WorkoutRecordResponse> getWorkoutRecordById(int id)
    {
        var data = RestService.For<IWorkoutDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetWorkoutRecordById(id).ConfigureAwait(false);
        WorkoutRecordResponse? workoutRecord = null;

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return workoutRecord = response.Content;
        }
        else
        {
            throw new Exception();
        }
    }

    //Update workout record
    public async Task<WorkoutRecordResponse> updateWorkoutRecordById(WorkoutRecordUpdate updateWorkoutRecord)
    {
        var data = RestService.For<IWorkoutDataProcessor>($"https://{_host}:{_port}");
        var response = await data.UpdateWorkoutRecord(updateWorkoutRecord).ConfigureAwait(false);
        WorkoutRecordResponse? workoutRecord = null;

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return workoutRecord = response.Content;
        }
        else
        {
            throw new Exception();
        }
    }

    //Delete
    public async Task<WorkoutRecordResponse> deleteWorkoutRecord(int id)
    {
        var data = RestService.For<IWorkoutDataProcessor>($"https://{_host}:{_port}");
        var response = await data.DeleteWorkoutRecord(id).ConfigureAwait(false);
        WorkoutRecordResponse? workoutRecord = null;

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return workoutRecord = response.Content;
        }
        else
        {
            throw new Exception();
        }
    }
}
