using FlashFitClassLibrary.InitialData;
using FlashFitClassLibrary.Models;
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
    
    
    //TODO: Registration 

    //TODO: Login 

    //Create User 
    public bool createUser(UserProfileModel user)
    {
        bool result = TemporaryDataStore.userProfiles.Add(user);
        return result;
    }

    public UserProfileModel updateUser(UserProfileModel updatedUser)
    {
        //TODO: Add exception handling 
        UserProfileModel user = TemporaryDataStore.userProfiles.Single(x => x.Email == updatedUser.Email);
        
        if(user != null)
        {
            user.Name = updatedUser.Name;
            user.Gender = updatedUser.Gender;
            user.WeightInKiloGrams = updatedUser.WeightInKiloGrams;
            user.HeightInCentiMeter = updatedUser.HeightInCentiMeter;
            user.BodyMassIndex = updatedUser.BodyMassIndex;
            return user;
        }
        else
        {
            return new UserProfileModel();

        }

       
    }

    public List<UserProfileModel> getUsers()
    {
        HashSet<UserProfileModel> original =  TemporaryDataStore.userProfiles;
        List<UserProfileModel> listOfUsers = new List<UserProfileModel> ();
        foreach(UserProfileModel user in original)
        {
            listOfUsers.Add(user);
        }
        return listOfUsers;
    }

    public UserProfileModel getUserByEmail(string email)
    {
        UserProfileModel userProfile = TemporaryDataStore.userProfiles.Single(x => x.Email == email);
        if(userProfile != null)
        {
            return userProfile;
        }
        else
        {
            return new UserProfileModel();
        }
    }

    //Update the Weight of the User
    public bool updateUserWeight(decimal updatedUserWeight, string userEmail)
    {
        //TODO: Add exception handling 
        UserProfileModel user = TemporaryDataStore.userProfiles.Single(x => x.Email == userEmail);
        if (user != null)
        {
            user.WeightInKiloGrams = updatedUserWeight;
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public decimal calculateAndUpdateBMI(string userEmail)
    {
        UserProfileModel userProfile = TemporaryDataStore.userProfiles.Single( x =>  x.Email == userEmail);
        decimal bmi;
       
        decimal height = userProfile.HeightInCentiMeter;
        decimal weight = userProfile.WeightInKiloGrams;

        height = height / 100;
        height = (height * height);

        bmi = weight / height;

        userProfile.BodyMassIndex = bmi;
        updateUser(userProfile);

        return bmi;
    }

    public decimal calculateAndUpdateBMI(string userEmail, decimal predictedWeight)
    {
        UserProfileModel userProfile = TemporaryDataStore.userProfiles.Single(x => x.Email == userEmail);
        decimal bmi;

        decimal height = userProfile.HeightInCentiMeter;
        decimal weight = predictedWeight;

        height = height / 100;
        height = (height * height);

        bmi = weight / height;

        return bmi;
    }

}
