using FlashFitClassLibrary.Enumz;

namespace FlashFitClassLibrary.Resources.User
{
    public sealed record RegisterResource(
        string Email,
        string Password,
        string Name,
        GenderTypeEnum Gender,
        DateTime BirthDate,
        decimal WeightInKiloGrams,
        decimal HeightInCentiMeter,
        decimal BodyMassIndex,
        HealthStatusEnum HeathStatus,
        DateTime DateCreated


        )
    {

    };

}
