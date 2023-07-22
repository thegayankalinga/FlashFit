using FlashFitClassLibrary.HttpApiProcessor;
using FlashFitClassLibrary.Resources.Cheatmeal;
using Refit;

namespace FlashFitClassLibrary.Services;

public class CheatmealService
{

    private readonly string _host = Environment.GetEnvironmentVariable("REMOTEAPIGATEWYHOST") ?? "localhost";
    private readonly string _port = Environment.GetEnvironmentVariable("REMOTEAPIGATEWAYPORT") ?? "7205";

    //TODO: Save cheatmeal type
    public async Task<CheatmealTypeCreation?> createCheatmealType(CheatmealTypeCreation toCreate)
    {
        var data = RestService.For<ICheatmealDataProcessor>($"https://{_host}:{_port}");
        var response = await data.CreateNewCheatmealType(toCreate).ConfigureAwait(false);

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return new CheatmealTypeCreation(
                response.Content.Name,
                response.Content.CheatmealCaloryGain,
                response.Content.DateCreated
                );
        }
        else
        {
            return null;
        }

    }

    //TODO: Get All cheatmeal types 
    public async Task<List<CheatmealTypeResponse>> getAllCheatmeal()
    {
        var data = RestService.For<ICheatmealDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetAllCheatmealTypes().ConfigureAwait(false);
        List<CheatmealTypeResponse>? records = new();

        if (response.Content != null)
        {
            foreach (CheatmealTypeResponse item in response.Content)
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

    //Get cheatmeal by ID
    public async Task<CheatmealTypeResponse?> getCheatmealById(int id)
    {
        var data = RestService.For<ICheatmealDataProcessor>($"https://{_host}:{_port}");
        var response = await data.GetCheatmealTypeById(id).ConfigureAwait(false);

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return new CheatmealTypeResponse(
                response.Content.Id,
                response.Content.Name,
                response.Content.CheatmealCaloryGain);
        }
        else
        {
            return null;
        }


    }

    //TODO: Update cheatmeal
    public async Task<CheatmealTypeResponse?> updateCheatmealById(CheatmealTypeUpdate updateModel)
    {
        var data = RestService.For<ICheatmealDataProcessor>($"https://{_host}:{_port}");
        var response = await data.UpdateCheatmealType(updateModel).ConfigureAwait(false);

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return new CheatmealTypeResponse(
                response.Content.Id,
                response.Content.Name,
                response.Content.CheatmealCaloryGain
                );
        }
        else
        {
            return null;
        }

    }

    //TODO: Delete cheatmeal type 
    public async Task<CheatmealTypeResponse?> deletecheatmealById(int id)
    {
        var data = RestService.For<ICheatmealDataProcessor>($"https://{_host}:{_port}");
        var response = await data.DeleteCheatmealById(id).ConfigureAwait(false);

        if (response.IsSuccessStatusCode && response.Content != null)
        {
            return new CheatmealTypeResponse(
                response.Content.Id,
                response.Content.Name,
                response.Content.CheatmealCaloryGain);

        }
        else
        {
            return null;
        }
    }

}
