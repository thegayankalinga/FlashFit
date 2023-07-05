using FlashFitClassLibrary;
using FlashFitClassLibrary.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace FlashFitConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This console application to test out the functionality when needed!");
            //Add initial WorkoutTypes 
            var incoming = new List<WorkoutModel>();
            string filePath = @"D:\Developer\c_sharp\FlashFit\FlashFitClassLibrary\InitialDataWorkoutModels.json";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                incoming = JsonConvert.DeserializeObject<List<WorkoutModel>>(json);
            }

            if(incoming != null && incoming.Count > 0)
            {
                foreach(WorkoutModel model in incoming)
                {
                    Console.WriteLine($"{model.WorkoutName}");
                }
            }
        }
    }
}