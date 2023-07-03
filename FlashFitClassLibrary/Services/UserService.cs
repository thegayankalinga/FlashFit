using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
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
            return user;
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
}
