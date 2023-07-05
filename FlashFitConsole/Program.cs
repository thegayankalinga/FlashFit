using FlashFitClassLibrary;
using FlashFitClassLibrary.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace FlashFitConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
                var incoming = new List<WorkoutRecordModel>();
                string filePath = @"D:\Developer\c_sharp\FlashFit\FlashFitClassLibrary\InitialDataWorkoutRecord.json";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string json = reader.ReadToEnd();
                    //incoming = JsonConvert.DeserializeObject<List<WorkoutRecordModel>>(json);
                    incoming = DeserializeUsingGenericSystemTextJson(json);
                }
           
            if (incoming != null && incoming.Count > 0)
                {
                

                foreach (WorkoutRecordModel model in incoming)

                    {
                    WorkoutRecordModel workoutRecord = new WorkoutRecordModel();
                    WorkoutModel workoutModel = new WorkoutModel();
                    //Console.WriteLine(model.Workout.WorkoutName);

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
                    Console.WriteLine(workoutRecord.WorkoutRecordId);



                }
                
            }
            }

        private static List<WorkoutRecordModel>? DeserializeUsingGenericSystemTextJson(string json)
        {
            List<WorkoutRecordModel> workoutRecs = System.Text.Json.JsonSerializer.Deserialize<List<WorkoutRecordModel>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return workoutRecs;
        }

    }
}