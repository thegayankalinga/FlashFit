using FlashFitClassLibrary.HttpApiProcessor;
using FlashFitClassLibrary.Resources.User;
using FlashFitClassLibrary.Resources.Workout;
using FlashFitClassLibrary.Utility;
using Refit;

namespace FlashFitClassLibrary.Services;

public class UserService

{

    private readonly string _host = Environment.GetEnvironmentVariable("REMOTEAPIGATEWYHOST") ?? "localhost";
    private readonly string _port = Environment.GetEnvironmentVariable("REMOTEAPIGATEWAYPORT") ?? "7205";

    


    //Registration
    public async Task<UserResource> createUser(RegisterResource user)
    {

        var settings = new RefitSettings
        {
            UrlParameterFormatter = new EnumsAsIntegersParameterFormatter()
        };

        var data = RestService.For<IUserDataProcessor>($"https://{_host}:{_port}", settings);
        var response = await data.RegisterUser(user);

        if (response.IsSuccessStatusCode)
        {
            return response.Content;
        }
        else
        {
            return null;
        }

    }

    //TODO: Email Verification Service to be added

    //Update User
    public async Task<UserResource?> updateUser(UserResource updatedUser)
    {
        var data = RestService.For<IUserDataProcessor>($"https://{_host}:{_port}");
        var response = await data.UpdateUser(updatedUser).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            return response.Content;
        }
        else
        {
            return null;
        }
    }

    //Get User by email
    public async Task<UserResource> getUserByEmail(string email)
    {
        var data = RestService.For<IUserDataProcessor>($"https://{_host}:{_port}");

        var response = await data.GetUser(email).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            return response.Content;
        }
        else
        {
            UserResource? nullUser = null;
            return nullUser;
        }

    }

    //Login
    public async Task<UserResource?> ValidateUser(string email, string password)
    {
        var data = RestService.For<IUserDataProcessor>($"https://{_host}:{_port}");
        LoginResource loginResource = new LoginResource(email, password);


        var response = await data.LoginUser(loginResource).ConfigureAwait(false);
        if (response.IsSuccessStatusCode)
        {
            return new UserResource(
                response.Content.Email,
                response.Content.Name,
                response.Content.Gender,
                response.Content.BirthDate,
                response.Content.WeightInKiloGrams,
                response.Content.HeightInCentiMeter,
                response.Content.BodyMassIndex,
                response.Content.HeathStatus);
        }

        return null;

    }


}
