using FlashFitClassLibrary.Enumz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
