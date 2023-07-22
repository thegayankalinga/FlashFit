using FlashFitClassLibrary.HttpApiProcessor;
using FlashFitClassLibrary.Resources.Prediction;
using Refit;

namespace FlashFitClassLibrary.Services;

public class PredictionService
{
    private readonly string _host = Environment.GetEnvironmentVariable("REMOTEAPIGATEWYHOST") ?? "localhost";
    private readonly string _port = Environment.GetEnvironmentVariable("REMOTEAPIGATEWAYPORT") ?? "7205";

    public async Task<PredictionResponse?> predictHealthStatus(string userEmail, DateTime toDate)
    {
    
        PredictionRequest predictionRequest = new PredictionRequest(userEmail, toDate);

        var data = RestService.For<IUtilityServiceDataProcessor>($"https://{_host}:{_port}");
        var response = await data.PredictHealthStatus(predictionRequest).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            return new PredictionResponse(
                response.Content.WeightPredicted,
                response.Content.BmiPredicted,
                response.Content.HealthStatusPredicted,
                response.Content.Suggestion
                
                );
        }
        else
        {
            return null;
        }

    }
}
