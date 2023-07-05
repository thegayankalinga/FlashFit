using FlashFitClassLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Connector;

public class JsonDeserializer
{
    //Add initial WorkoutTypes 
   

    public static void loadWorkoutModelsFromJson()
    {
        var incoming = new List<WorkoutModel>();
        string filePath = @"D:\Developer\c_sharp\FlashFit\FlashFitClassLibrary\InitialDataWorkoutModels.json";
        using (StreamReader reader = new StreamReader(filePath))
        {
            string json = reader.ReadToEnd();
            incoming = JsonConvert.DeserializeObject<List<WorkoutModel>>(json);
        }

        if (incoming != null && incoming.Count > 0)
        {
            foreach (WorkoutModel model in incoming)
            {
                TemporaryDataStore.workoutModels.Add(model);
            }
        }
    }

    public static void loadWorkoutRecordFromJson()
    {
        var incoming = new List<WorkoutRecordModel>();
        string filePath = @"D:\Developer\c_sharp\FlashFit\FlashFitClassLibrary\InitialDataWorkoutRecord.json";
        using (StreamReader reader = new StreamReader(filePath))
        {
            string json = reader.ReadToEnd();
            //incoming = JsonConvert.DeserializeObject<List<WorkoutRecordModel>>(json);
           incoming = System.Text.Json.JsonSerializer.Deserialize<List<WorkoutRecordModel>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
      
        }

        if (incoming != null && incoming.Count > 0)
        {
            
            foreach (WorkoutRecordModel model in incoming)
            {
                WorkoutRecordModel workoutRecord = new WorkoutRecordModel();
                WorkoutModel workoutModel = new WorkoutModel();

                
                    workoutModel.WorkoutID = model.Workout.WorkoutID;
                    workoutModel.WorkoutName = model.Workout.WorkoutName;
                    workoutModel.WorkoutType = model.Workout.WorkoutType;
                    workoutModel.CaloryBurnRate = model.Workout.CaloryBurnRate;
              
               
                    workoutRecord.WorkoutRecordId = model.WorkoutRecordId;
                    workoutRecord.Workout = workoutModel;
                    workoutRecord.UserEmail = model.UserEmail;
                    workoutRecord.WorkedoutDateTime = model.WorkedoutDateTime;
                    workoutRecord.WeightAtCompletion = model.WeightAtCompletion;
         
                TemporaryDataStore.workoutRecords.Add(workoutRecord);

            }
        }
    }





}
