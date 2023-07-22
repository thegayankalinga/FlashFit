using FlashFitClassLibrary.InitialData;
using FlashFitClassLibrary.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace FlashFitClassLibrary.Connector;

public class JsonDeserializer
{
    //Add initial WorkoutTypes 



    public static void loadWorkoutModelsFromJson()
    {
        var incoming = new List<WorkoutModel>();
        string filePath = @"D:\Developer\c_sharp\FlashFit\FlashFitClassLibrary\InitialData\InitialDataWorkoutModels.json";
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


    public static void loadCheatmealModelsFromJson()
    {
        string filePath = @"D:\Developer\c_sharp\FlashFit\FlashFitClassLibrary\InitialData\InitialDataCheatmeals.json";
        var incoming = new List<CheatmealModel>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string json = reader.ReadToEnd();
            incoming = JsonConvert.DeserializeObject<List<CheatmealModel>>(json);
        }
        if (incoming != null && incoming.Count > 0)
        {
            foreach (CheatmealModel model in incoming)
            {

                TemporaryDataStore.cheatmealModels.Add(model);
            }
        }
    }

    public static T ConvertValue<T, U>(U value) where U : IConvertible
    {
        return (T)Convert.ChangeType(value, typeof(T));
    }

    public static void loadWorkoutRecordFromJson()
    {
        var incoming = new List<WorkoutRecordModel>();
        string filePath = @"D:\Developer\c_sharp\FlashFit\FlashFitClassLibrary\InitialData\InitialDataWorkoutRecord.json";
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


                //workoutModel.WorkoutID = model.Workout.WorkoutID;
                //workoutModel.WorkoutName = model.Workout.WorkoutName;
                //workoutModel.WorkoutType = model.Workout.WorkoutType;
                //workoutModel.CaloryBurnRate = model.Workout.CaloryBurnRate;


                //workoutRecord.WorkoutRecordId = model.WorkoutRecordId;
                //workoutRecord.Workout = workoutModel;
                //workoutRecord.UserEmail = model.UserEmail;
                //workoutRecord.WorkedoutDateTime = model.WorkedoutDateTime;
                //workoutRecord.WeightAtCompletion = model.WeightAtCompletion;

                TemporaryDataStore.workoutRecords.Add(workoutRecord);

            }
        }
    }

    //InitialDataCheatmealRecords

    public static void loadCheatmealRecordFromJson()
    {
        var incoming = new List<CheatmealRecordModel>();
        string filePath = @"D:\Developer\c_sharp\FlashFit\FlashFitClassLibrary\InitialData\InitialDataCheatmealRecords.json";
        using (StreamReader reader = new StreamReader(filePath))
        {

            string json = reader.ReadToEnd();
            //incoming = JsonConvert.DeserializeObject<List<WorkoutRecordModel>>(json);
            incoming = System.Text.Json.JsonSerializer.Deserialize<List<CheatmealRecordModel>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        }

        if (incoming != null && incoming.Count > 0)
        {

            foreach (CheatmealRecordModel model in incoming)
            {
                CheatmealRecordModel cheatmealRecord = new CheatmealRecordModel();
                CheatmealModel cheatmealModel = new CheatmealModel();


                cheatmealModel.CheatmealId = model.Cheatmeal.CheatmealId;
                cheatmealModel.CheatmealName = model.Cheatmeal.CheatmealName;
                cheatmealModel.CheatCalorieGain = model.Cheatmeal.CheatCalorieGain;


                cheatmealRecord.CheatmealRecordID = model.CheatmealRecordID;
                cheatmealRecord.Cheatmeal = cheatmealModel;
                cheatmealRecord.UserEmail = model.UserEmail;
                cheatmealRecord.CheatmealAddedDateTime = model.CheatmealAddedDateTime;
                cheatmealRecord.WeightAtMealRecordTime = model.WeightAtMealRecordTime;

                TemporaryDataStore.cheatmealRecords.Add(cheatmealRecord);

            }
        }
    }





}
