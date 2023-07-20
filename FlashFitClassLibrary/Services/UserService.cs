using FlashFitClassLibrary.InitialData;
using FlashFitClassLibrary.Models;
using FlashFitClassLibrary.Resources.User;
using FlashFitUIClassLibrary.HttpApiProcessor;
using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Services;

public class UserService

{

    private readonly string _host = Environment.GetEnvironmentVariable("REMOTEAPIGATEWYHOST");
    private readonly string _port = Environment.GetEnvironmentVariable("REMOTEAPIGATEWAYPORT");


    //TODO: Registration 

    //TODO: Login 

    //Create User 
    public async Task<UserResource> createUser(RegisterResource user)
    {
        
        var data = RestService.For<IUserDataProcessor>($"https://{_host}:{_port}");
        var response = await data.RegisterUser(user);

        if(response.IsSuccessStatusCode)
        {
            return response.Content;
        }
        else
        {
            UserResource? nullUser = null;
            return nullUser;
        }
        
    }

    public async Task<UserResource> updateUser(UserResource updatedUser)
    {
        var data = RestService.For<IUserDataProcessor>($"https://{_host}:{_port}");
        var response = await data.UpdateUser(updatedUser);

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

    public async Task<UserResource> getUserByEmail(string email)
    {
        var data = RestService.For<IUserDataProcessor>($"https://{_host}:{_port}");

        var response = await data.GetUser(email);
 
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

    ////Update the Weight of the User
    //public bool updateUserWeight(decimal updatedUserWeight, string userEmail)
    //{
    //    //TODO: Add exception handling 
    //    UserProfileModel user = TemporaryDataStore.userProfiles.Single(x => x.Email == userEmail);
    //    if (user != null)
    //    {
    //        user.WeightInKiloGrams = updatedUserWeight;
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }

    //}

    //public decimal calculateAndUpdateBMI(string userEmail)
    //{
    //    UserProfileModel userProfile = TemporaryDataStore.userProfiles.Single( x =>  x.Email == userEmail);
    //    decimal bmi;

    //    decimal height = userProfile.HeightInCentiMeter;
    //    decimal weight = userProfile.WeightInKiloGrams;

    //    height = height / 100;
    //    height = (height * height);

    //    bmi = weight / height;

    //    userProfile.BodyMassIndex = bmi;
    //    updateUser(userProfile);

    //    return bmi;
    //}

    //public decimal calculateAndUpdateBMI(string userEmail, decimal predictedWeight)
    //{
    //    UserProfileModel userProfile = TemporaryDataStore.userProfiles.Single(x => x.Email == userEmail);
    //    decimal bmi;

    //    decimal height = userProfile.HeightInCentiMeter;
    //    decimal weight = predictedWeight;

    //    height = height / 100;
    //    height = (height * height);

    //    bmi = weight / height;

    //    return bmi;
    //}

}
