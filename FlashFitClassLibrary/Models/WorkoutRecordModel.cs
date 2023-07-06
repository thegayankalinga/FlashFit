using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Models
{
    public class WorkoutRecordModel
    {
        public int WorkoutRecordId { get; set; }

        [JsonConverter(typeof(WorkoutModel))]
        public WorkoutModel Workout { get; set; }
        public string UserEmail { get; set; }
        public DateTime WorkedoutDateTime { get; set; }
        public decimal WeightAtCompletion { get; set; }

        [JsonConstructor]
        public WorkoutRecordModel()
        {
        }

        [JsonConstructor]
        public WorkoutRecordModel(int workoutRecordId, WorkoutModel workout, string userEmail, DateTime workedoutDateTime, decimal weightAtCompletion)
        {
            WorkoutRecordId = workoutRecordId;
            Workout = workout;
            UserEmail = userEmail;
            WorkedoutDateTime = workedoutDateTime;
            WeightAtCompletion = weightAtCompletion;
        }
    }
}
