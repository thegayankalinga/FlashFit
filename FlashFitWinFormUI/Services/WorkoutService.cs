using FlashFitClassLibrary.InitialData;
using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Services
{
    public class WorkoutService
    {
        //TODO: Save workout
        public bool createWorkout(WorkoutModel workoutModel)
        {
            if (workoutModel != null) { 
                TemporaryDataStore.workoutModels.Add(workoutModel);
                return true;
            }
            else
            {
                return false;
            }
            
           
        }

        //TODO: Get workouts 
        public List<WorkoutModel> getAllWorkouts()
        {
            return TemporaryDataStore.workoutModels;
        }

        //Get by ID
        public WorkoutModel getWorkoutById(int id)
        {
            WorkoutModel? resultOfFind = TemporaryDataStore.workoutModels.Find(x => x.WorkoutID == id);

            if (resultOfFind != null)
            {
                return resultOfFind;
            }
            else
            {
                return new WorkoutModel();
            }
        }

        //TODO: Update workout
        public bool updateWorkoutById(WorkoutModel workoutModel)
        {
            WorkoutModel? resultOfFind = TemporaryDataStore.workoutModels.Find(x => x.WorkoutID == workoutModel.WorkoutID);
            if (resultOfFind != null)
            {
                resultOfFind.WorkoutName = workoutModel.WorkoutName;
                resultOfFind.WorkoutType = workoutModel.WorkoutType;
                resultOfFind.CaloryBurnRate = workoutModel.CaloryBurnRate;

                return true;
            }else
            {
                return false;
            }
        }

        //TODO: Delete workout 
        public bool deleteWorkoutById(int id)
        {
            return TemporaryDataStore.workoutModels.Remove(getWorkoutById(id));
        }

    }
}
