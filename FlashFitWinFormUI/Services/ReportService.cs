using FlashFitClassLibrary.HttpApiProcessor;
using FlashFitClassLibrary.Resources.CheatmealRecord;
using FlashFitClassLibrary.Resources.Report;
using FlashFitClassLibrary.Resources.WorkoutRecord;
using Refit;

namespace FlashFitWinFormUI.Services;

public class ReportService
{
    private readonly string _host = Environment.GetEnvironmentVariable("REMOTEAPIGATEWYHOST") ?? "localhost";
    private readonly string _port = Environment.GetEnvironmentVariable("REMOTEAPIGATEWAYPORT") ?? "7205";
    public async Task<List<CheatmealRecordResponse>> getAllCheatmealsByEmail(string email)
    {
        var data = RestService.For<IUtilityServiceDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetCheatmealReportByEmail(email).ConfigureAwait(false);
        
        List<CheatmealRecordResponse>? records = new();

        if (response.IsSuccessStatusCode)
        {
            foreach (CheatmealRecordResponse item in response.Content)
            {
                records.Add(item);
            }
            return records;
        }
        else
        {
            return records;
        }

    }

    public async Task<List<CheatmealRecordResponse>> getAllCheatmealsByEmailAndDate(ReportRequest request)
    {
        var data = RestService.For<IUtilityServiceDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetCheatmealReportByEmailAndDate(request).ConfigureAwait(false);
        List<CheatmealRecordResponse>? records = new();

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            foreach (CheatmealRecordResponse item in response.Content)
            {
                records.Add(item);
            }
            return records;
        }
        else
        {
            throw new Exception();
        }

    }

    public async Task<List<WorkoutRecordResponse>> getAllWorkoutssByEmail(string email)
    {
        var data = RestService.For<IUtilityServiceDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetWokroutReportByEmail(email).ConfigureAwait(false);
        List<WorkoutRecordResponse>? records = new();

        if (response.IsSuccessStatusCode)
        {
            foreach (WorkoutRecordResponse item in response.Content)
            {
                records.Add(item);
            }
            return records;
        }
        else
        {
            return records;
        }

    }


    public async Task<List<WorkoutRecordResponse>> getAllWorkoutssByEmailAndDate(ReportRequest request)
    {
        var data = RestService.For<IUtilityServiceDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetWorkoutReportByEmailAndDate(request).ConfigureAwait(false);
        List<WorkoutRecordResponse>? records = new();

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            foreach (WorkoutRecordResponse item in response.Content)
            {
                records.Add(item);
            }
            return records;
        }
        else
        {
            return records;
        }

    }

}
