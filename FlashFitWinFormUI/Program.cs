using FlashFitClassLibrary.Connector;
using FlashFitClassLibrary.Resources.User;


namespace FlashFitWinFormUI;

public static class Program
{

    public static UserResource loggedInUser;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        ApplicationConfiguration.Initialize();

        //TODO: To remove with microservice implementation
        //Loading initial Data
        //TemporaryDataStore.userProfiles.Add(getLoggedInUser());
        JsonDeserializer.loadWorkoutModelsFromJson();
        JsonDeserializer.loadWorkoutRecordFromJson();
        JsonDeserializer.loadCheatmealModelsFromJson();
        JsonDeserializer.loadCheatmealRecordFromJson();

        Environment.SetEnvironmentVariable("REMOTEAPIGATEWYHOST", "localhost");
        Environment.SetEnvironmentVariable("REMOTEAPIGATEWAYPORT", "7205");

        Application.Run(new UserLoginForm());

    }

    public static UserResource getLoggedInUser()
    {
        if (loggedInUser == null)
        {
            throw new InvalidProgramException("No user Found");
        }
        else
        {
            return loggedInUser;
        }
    }


}