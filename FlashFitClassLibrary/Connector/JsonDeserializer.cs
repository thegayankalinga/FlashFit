using FlashFitClassLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.Connector;

public class JsonDeserializer
{
    //Add initial WorkoutTypes 
   

    public static void loadWorkoutModelsFromJson()
    {
        var incoming = new List<WorkoutModel>();
        string filePath = @"D:\Developer\c_sharp\FlashFit\FlashFitClassLibrary\InitialDataWorkoutModels.json";
        using (StreamReader reader = new StreamReader(filePath))
        {
            string json = reader.ReadToEnd();
            incoming = JsonConvert.DeserializeObject<List<WorkoutModel>>(json);
        }

        if (incoming != null && incoming.Count > 0)
        {
            foreach (WorkoutModel model in incoming)
            {
                TemporaryDataStore.workoutModels.Add(model);
            }
        }
    }
  
    

            

}
