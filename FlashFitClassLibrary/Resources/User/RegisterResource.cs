using FlashFitClassLibrary.Enumz;

namespace FlashFitClassLibrary.Resources.User
{
    public sealed record RegisterResource(
        string Email,
        string Password,
        string Name,
        string Gender,
        DateTime BirthDate,
        decimal WeightInKiloGrams,
        decimal HeightInCentiMeter,
        decimal BodyMassIndex,
        string HeathStatus
        )
    {

    };

}
