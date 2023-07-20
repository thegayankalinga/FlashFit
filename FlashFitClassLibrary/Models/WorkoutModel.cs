using FlashFitClassLibrary.Enumz;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashFitClassLibrary.Models
{
    public class WorkoutModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkoutID { get; set; }
        [Required]
        public string WorkoutName { get; set;}

        [JsonConverter(typeof(StringEnumConverter))]
        [EnumDataType(typeof(WorkoutTypeEnum))]
        [Column(TypeName = "nvarchar(129)")]
        public WorkoutTypeEnum WorkoutType { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal CaloryBurnRate { get; set; }

        public DateTime DateCreated { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DateUpdated { get; set; }



    }
}
