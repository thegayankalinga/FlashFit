using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Models;

public class CheatmealRecordModel
{
    public int CheatmealRecordID { get; set; }

    public CheatmealModel Cheatmeal { get; set; }
    public string UserEmail { get; set; }
    public DateTime CheatmealAddedDateTime { get; set; }
    public decimal WeightAtMealRecordTime { get; set; }

    public CheatmealRecordModel()
    {
    }

    public CheatmealRecordModel(int cheatmealRecordID, CheatmealModel cheatmeal, string userEmail, DateTime cheatmealAddedDateTime, decimal weightAtMealRecordTime)
    {
        CheatmealRecordID = cheatmealRecordID;
        Cheatmeal = cheatmeal;
        UserEmail = userEmail;
        CheatmealAddedDateTime = cheatmealAddedDateTime;
        WeightAtMealRecordTime = weightAtMealRecordTime;
    }
}
