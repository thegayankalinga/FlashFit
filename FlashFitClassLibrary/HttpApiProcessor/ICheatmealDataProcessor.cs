using FlashFitClassLibrary.Resources.CheatmealRecord;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFitClassLibrary.HttpApiProcessor
{
    public interface ICheatmealDataProcessor
    {

        //From API Gateway



        //From Internal Services
        [Get(path: "/cheatmealrecord/byuser/{email}")]
        Task<ApiResponse<IEnumerable<CheatmealRecordResponse>>> GetInternalCheatmealHistoryForUser(string email);

        
    }
}
