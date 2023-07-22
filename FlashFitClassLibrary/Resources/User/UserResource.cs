using FlashFitClassLibrary.Enumz;

namespace FlashFitClassLibrary.Resources.User
{
    public sealed record UserResource(
        string Email,
        string Name,
        string Gender,
        DateTime BirthDate,
        decimal WeightInKiloGrams,
        decimal HeightInCentiMeter,
        decimal BodyMassIndex,
        string HeathStatus
        )
    {
    }
}
