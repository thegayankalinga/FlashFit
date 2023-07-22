namespace FlashFitClassLibrary.Resources.Prediction
{
    public sealed record PredictionRequest(
            string UserEmail,
            DateTime futureDate
        )
    {
    }
}
