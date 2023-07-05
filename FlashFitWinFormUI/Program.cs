using FlashFitClassLibrary;
using FlashFitClassLibrary.Connector;
using FlashFitClassLibrary.Models;
using FlashFitClassLibrary.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace FlashFitWinFormUI;

public static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]

    public static UserProfileModel getLoggedInUser()
    {
        UserProfileModel loggedInUser = new UserProfileModel();
        loggedInUser.Name = "Gayan Kalinga";
        loggedInUser.Email = "bg15407@gmail.com";
        loggedInUser.Gender = FlashFitClassLibrary.Enumz.GenderTypeEnum.MALE;
        loggedInUser.WeightInKiloGrams = 65;
        loggedInUser.HeightInCentiMeter = 150;

        return loggedInUser;
    }
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        ApplicationConfiguration.Initialize();

        //TODO: To remove with microservice implementation 
        TemporaryDataStore.userProfiles.Add(getLoggedInUser());
        JsonDeserializer.loadWorkoutModelsFromJson();
        JsonDeserializer.loadWorkoutRecordFromJson();


        Application.Run(new MainForm());
        
    }


}