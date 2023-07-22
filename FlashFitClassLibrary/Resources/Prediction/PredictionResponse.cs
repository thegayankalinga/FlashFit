using FlashFitClassLibrary.Enumz;

namespace FlashFitClassLibrary.Resources.Prediction
{
    public sealed record PredictionResponse(
            decimal WeightPredicted,
            decimal BmiPredicted,
            HealthStatusEnum HealthStatusPredicted,
            string Suggestion
        )
    {
    }
}
