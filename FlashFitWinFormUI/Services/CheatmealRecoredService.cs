using FlashFitClassLibrary.InitialData;
using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Services;

public class CheatmealRecoredService
{
    //create
    public bool createCheatmealRecord(CheatmealRecordModel model)
    {
        if(model != null)
        {
            TemporaryDataStore.cheatmealRecords.Add(model);
            return true;
        }else { return false; }
    }

    //get
    public List<CheatmealRecordModel> getCheatmealRecords()
    {
        return TemporaryDataStore.cheatmealRecords;
    }

    //get by id
    public CheatmealRecordModel getCheatmealRecordById(int id)
    {
        CheatmealRecordModel? result = TemporaryDataStore.cheatmealRecords.Find(x => x.CheatmealRecordID == id);
        if(result != null)
        {
            return result;
        }
        else
        {
            return new CheatmealRecordModel();
        }
    }

    //get by email & date range
    public List<CheatmealRecordModel> getCheatmealRecordsByEmailAndDateRange(string email, DateTime from, DateTime to)
    {
        List<CheatmealRecordModel> list = TemporaryDataStore.cheatmealRecords.Where(x => x.UserEmail == email && x.CheatmealAddedDateTime <= to && x.CheatmealAddedDateTime >= from).ToList();

        return list;
    }

    //update
    public bool updateCheatmealRecord(CheatmealRecordModel cheatmealRecord)
    {
        CheatmealRecordModel? result = TemporaryDataStore.cheatmealRecords.Find(x => x.CheatmealRecordID == cheatmealRecord.CheatmealRecordID);
        if(result != null)
        {
            result.Cheatmeal = cheatmealRecord.Cheatmeal;
            result.CheatmealAddedDateTime = cheatmealRecord.CheatmealAddedDateTime;
            result.WeightAtMealRecordTime = cheatmealRecord.WeightAtMealRecordTime;
            result.CheatmealAddedDateTime = cheatmealRecord.CheatmealAddedDateTime;

            return true;
        }else { return false; }
    }

    //delete
    public bool deleteCheatmealRecord(int id)
    {
        return TemporaryDataStore.cheatmealRecords.Remove(getCheatmealRecordById(id));
    }

}
