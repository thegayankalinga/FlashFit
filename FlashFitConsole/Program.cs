using FlashFitClassLibrary;
using FlashFitClassLibrary.Connector;
using FlashFitClassLibrary.Models;
using FlashFitClassLibrary.Services;
using Newtonsoft.Json;
using System.Text.Json;

namespace FlashFitConsole;

internal class Program
{
    static void Main(string[] args)

    
    {
        //Loading initial Data
        //TemporaryDataStore.userProfiles.Add(getLoggedInUser());
        JsonDeserializer.loadWorkoutModelsFromJson();
        JsonDeserializer.loadWorkoutRecordFromJson();
        JsonDeserializer.loadCheatmealModelsFromJson();
        JsonDeserializer.loadCheatmealRecordFromJson();

        PredictionService predictionService = new PredictionService();
        decimal weight = predictionService.weightPredication("bg15407@gmail.com",
            "2023-07-30T18:25:43.511Z", 65);

        Console.WriteLine(weight.ToString());
    }


}