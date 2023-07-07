using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Services;

public class CheatmealService
{

    //create
    public bool createCheatmeal(CheatmealModel model)
    {
        if(model != null)
        {
            TemporaryDataStore.cheatmealModels.Add(model);
            return true;
        }
        else
        {
            return false;
        }
        
    }

    //get 
    public List<CheatmealModel> getAllCheatmeals()
    {
        return TemporaryDataStore.cheatmealModels;
    }

    //get by id
    public CheatmealModel getCheatmealById(int id)
    {
        CheatmealModel? resultOfFind = TemporaryDataStore.cheatmealModels.Find(x => x.CheatmealId == id);
        if(resultOfFind != null)
        {
            return resultOfFind;
        }
        else
        {
            return new CheatmealModel();
        }
    }

    //update
    public bool updateCheatmeal(CheatmealModel cheatmeal)
    {
        CheatmealModel? resultOfFind = TemporaryDataStore.cheatmealModels.Find(x => x.CheatmealId == cheatmeal.CheatmealId);
        if(resultOfFind != null)
        {
            resultOfFind.CheatmealName = cheatmeal.CheatmealName;
            resultOfFind.CheatCalorieGain = cheatmeal.CheatCalorieGain;
            return true;
        }else { return false; }
    }

    //delete
    public bool deleteCheatmeal(int id)
    {
        return TemporaryDataStore.cheatmealModels.Remove(getCheatmealById(id));
    }

    public List<CheatmealRecordModel> getCheatmealRecordsByEmailAndDateRange(string email, DateTime from, DateTime to)
    {
        List<CheatmealRecordModel> list = TemporaryDataStore.cheatmealRecords.Where(x => x.UserEmail == email && x.CheatmealAddedDateTime <= to && x.CheatmealAddedDateTime >= from).ToList();

        return list;
    }
    
    public List<CheatmealRecordModel> GetCheatmealRecordModelsByEmail(string email)
    {
        List<CheatmealRecordModel> lsit = TemporaryDataStore.cheatmealRecords.Where(x => x.UserEmail.Contains(email)).ToList();
        return lsit;
    }
}
