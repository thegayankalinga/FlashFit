using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Services;

public class WorkoutRecordService
{
    //Save
    public bool createWorkoutRecord(WorkoutRecordModel workoutRecord)
    {
        if(workoutRecord != null)
        {
            TemporaryDataStore.workoutRecords.Add(workoutRecord);
            return true;
        }else { return false; }
    }

    //Get
    public List<WorkoutRecordModel> getWorkoutRecords() { return TemporaryDataStore.workoutRecords;}

    //Get by ID
    public WorkoutRecordModel getWorkoutRecordById(int id)
    {
        WorkoutRecordModel? resultOfFind = TemporaryDataStore.workoutRecords.Find(x => x.WorkoutRecordId == id);
        if (resultOfFind != null)
        {
            return resultOfFind;
        }
        else { return new WorkoutRecordModel(); }
    }
    //Update
    public bool updateWorkoutRecordById(WorkoutRecordModel workoutRecord)
    {
        WorkoutRecordModel? resultOfFind = TemporaryDataStore.workoutRecords.Find(x => x.WorkoutRecordId == workoutRecord.WorkoutRecordId);
        if (resultOfFind != null)
        {
            resultOfFind.Workout = workoutRecord.Workout;
            resultOfFind.WorkedoutDateTime = workoutRecord.WorkedoutDateTime;
            resultOfFind.WeightAtCompletion = workoutRecord.WeightAtCompletion;

            return true;
        }
        else
        {
            return false;
        }
    }

    //Delete
    public bool deleteWorkoutRecord(int id)
    {
        return TemporaryDataStore.workoutRecords.Remove(getWorkoutRecordById(id));
    }
}
