using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FlashFitClassLibrary;

//[JsonConverter(typeof(StringEnumConverter))]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WorkoutTypeEnum
{
    [EnumMember(Value = "STRENGTH")]
    STRENGTH,

    [EnumMember(Value = "AEROBICS")]
    AEROBICS,

    [EnumMember(Value = "FLEXIBILITY")]
    FLEXIBILITY,

    [EnumMember(Value = "HIGHINTENSITY")]
    HIGHINTENSITY,

}

//https://marathonhandbook.com/different-types-of-workouts/

