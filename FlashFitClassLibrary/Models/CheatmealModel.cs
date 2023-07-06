using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Models;

public class CheatmealModel
{
    public int CheatmealId { get; set; }
    public string CheatmealName { get; set; }
    public decimal CheatCalorieGain { get; set; }


    public CheatmealModel()
    {
    }
    
    [JsonConstructor]
    public CheatmealModel(int cheatmealId, string cheatmealName, decimal cheatCalorieGain)
    {
        CheatmealId = cheatmealId;
        CheatmealName = cheatmealName;
        CheatCalorieGain = cheatCalorieGain;
    }
}
