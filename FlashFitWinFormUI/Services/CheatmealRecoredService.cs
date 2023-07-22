using FlashFitClassLibrary.HttpApiProcessor;
using FlashFitClassLibrary.Resources.CheatmealRecord;
using Refit;

namespace FlashFitClassLibrary.Services;

public class CheatmealRecoredService
{
    private readonly string _host = Environment.GetEnvironmentVariable("REMOTEAPIGATEWYHOST") ?? "localhost";
    private readonly string _port = Environment.GetEnvironmentVariable("REMOTEAPIGATEWAYPORT") ?? "7205";
    //create
    public async Task<CheatmealRecordCreation?> createCheatmealRecord(CheatmealRecordCreation model)
    {
        var data = RestService.For<ICheatmealDataProcessor>($"https://{_host}:{_port}");
        var response = await data.CreateNewChetmealRecord(model).ConfigureAwait(false);


        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return new CheatmealRecordCreation(
                response.Content.CheatmealId,
                response.Content.UserEmail,
                response.Content.WeightAtRecordTime,
                response.Content.CheatmealRecordedDateTime,
                response.Content.CheatmealAddedDateTime
                );
        }
        else
        {
            return null;

        }
    }

    //get all record by email
    public async Task<List<CheatmealRecordResponse>> getCheatmealRcordsByEmail(string email)
    {
        var data = RestService.For<ICheatmealDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetAllChetmealRecordsByEmail(email).ConfigureAwait(false);

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

    //get by id
    public async Task<CheatmealRecordResponse?> getCheatmealRecordById(int id)
    {
        var data = RestService.For<ICheatmealDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetChetmealRecordById(id).ConfigureAwait(false);


        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return new CheatmealRecordResponse(
                response.Content.CheatmealRecordId,
                response.Content.Cheatmeal,
                response.Content.UserEmail,
                response.Content.CheatmealAddedDateTime,
                response.Content.WeightAtRecordTime
                );
        }
        else
        {
            return null;
        }
    }

    //update
    public async Task<CheatmealRecordResponse?> updateCheatmealRecord(CheatmealReocrdUpdate cheatmealRecord)
    {
        var data = RestService.For<ICheatmealDataProcessor>($"https://{_host}:{_port}");
        var response = await data.UpdateChetmealRecord(cheatmealRecord).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            return new CheatmealRecordResponse(
                response.Content.CheatmealRecordId,
                response.Content.Cheatmeal,
                response.Content.UserEmail,
                response.Content.CheatmealAddedDateTime, 
                response.Content.WeightAtRecordTime
                );
        }
        else
        {
            return null;
        }
    }

    //delete
    public async Task<CheatmealRecordResponse?> deleteCheatmealRecord(int id)
    {
        var data = RestService.For<ICheatmealDataProcessor>($"https://{_host}:{_port}");
        var response = await data.DeleteChetmealRecord(id).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            return new CheatmealRecordResponse(
                response.Content.CheatmealRecordId,
                response.Content.Cheatmeal,
                response.Content.UserEmail,
                response.Content.CheatmealAddedDateTime,
                response.Content.WeightAtRecordTime
                );
        }
        else
        {
            return null;
        }
    }

}
