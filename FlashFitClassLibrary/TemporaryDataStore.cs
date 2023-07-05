﻿using FlashFitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary;

public static class TemporaryDataStore
{
    //public static List<UserProfileModel> userProfiles = new(); 
    public static int WorkoutIDCounter =0;
    public static int WorkoutRecordIDCounter = 0;


    public static HashSet<UserProfileModel> userProfiles = new HashSet<UserProfileModel>();
    public static List<WorkoutModel> workoutModels = new List<WorkoutModel>();
    public static List<WorkoutRecordModel> workoutRecords = new List<WorkoutRecordModel>();
}
