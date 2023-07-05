using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace FlashFitClassLibrary.Models
{
    public class WorkoutModel
    {
        public int WorkoutID { get; set; }
        public string WorkoutName { get; set;}

        [JsonConverter(typeof(StringEnumConverter))]
        public WorkoutTypeEnum WorkoutType { get; set; }
        public decimal CaloryBurnRate { get; set; }

    }
}
