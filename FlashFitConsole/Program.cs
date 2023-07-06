using FlashFitClassLibrary;
using FlashFitClassLibrary.Connector;
using FlashFitClassLibrary.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace FlashFitConsole;

internal class Program
{
    static void Main(string[] args)

    
    {

        JsonDeserializer .loadCheatmealModelsFromJson();
    }


}