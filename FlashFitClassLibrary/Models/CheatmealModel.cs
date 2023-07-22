using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FlashFitClassLibrary.Models;

public class CheatmealModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CheatmealId { get; set; }
    [Required]
    public string CheatmealName { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal CheatCalorieGain { get; set; }
    public DateTime DateCreated { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? DateUpdated { get; set; }

    public CheatmealModel()
    {
    }

    [JsonConstructor]
    public CheatmealModel(int cheatmealId, string cheatmealName, decimal cheatCalorieGain)
    {
        CheatmealId = cheatmealId;
        CheatmealName = cheatmealName;
        CheatCalorieGain = cheatCalorieGain;
        DateCreated = DateTime.Now;

    }
}
