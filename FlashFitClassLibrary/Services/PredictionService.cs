using FlashFitClassLibrary.Enumz;
using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FlashFitClassLibrary.Services;

public class PredictionService
{
    WorkoutRecordService workoutRecordService = new WorkoutRecordService();
    CheatmealService cheatmealService = new CheatmealService(); 

    public decimal weightPredication(string userEmail, string to, decimal currentWeight)
    {
        decimal predictedWeight = 0;
        int noOfDays = 0;
        decimal sumOfWeights = 0;
        decimal averageWeight = 0;
        DateTime fromDate = DateTime.Now;
        DateTime toDate = DateTime.Parse(to);
        int noOfDaysPredictionIsRequiredFor = (int)(toDate - fromDate).TotalDays;

        if(noOfDaysPredictionIsRequiredFor == 0)
        {
            noOfDaysPredictionIsRequiredFor = 1;
        }

        //Get the daily average weight per each day as one day can have multiple weight records
        List<decimal> weightsForGivenPeriod = new List<decimal>();

        //Get the history
        foreach (WorkoutRecordModel wrm in workoutRecordService.getWorkoutRecordsByEmail(userEmail)){
            weightsForGivenPeriod.Add(wrm.WeightAtCompletion);
        }

        foreach(CheatmealRecordModel crm in cheatmealService.GetCheatmealRecordModelsByEmail(userEmail)){
            weightsForGivenPeriod.Add(crm.WeightAtMealRecordTime);
        }

        //get the average for the day & add all averages to a list
        if(weightsForGivenPeriod.Count > 0) {
            decimal diff = weightsForGivenPeriod.Max() - weightsForGivenPeriod.Min();

            //noOfDays = weightsForGivenPeriod.Count;

            averageWeight = diff / noOfDaysPredictionIsRequiredFor;
            
            predictedWeight = noOfDaysPredictionIsRequiredFor * averageWeight;
            predictedWeight = predictedWeight + currentWeight; 

            return predictedWeight;
        }
        else
        {
            return -1;
        }
        
    }

    public HealthStatusEnum getCurrentHealthStatus(string userEmail, decimal val)
    {
        UserService userService = new UserService();
        UserProfileModel userProfile = userService.getUserByEmail(userEmail);
        double bmi = (double)val;

        if(bmi <= 18.5)
        {
            return HealthStatusEnum.Underweight;
        }else if(bmi > 18.5 && bmi <= 24.9)
        {
            return HealthStatusEnum.Normalweight;
        }else if(bmi > 25 && bmi <= 29.9)
        {
            return HealthStatusEnum.Overweight;
        }else if(bmi >= 30)
        {
            return HealthStatusEnum.Obesity;
        }

        return HealthStatusEnum.None;
    }
}
