using FlashFitClassLibrary.Resources.Cheatmeal;
using FlashFitClassLibrary.Resources.CheatmealRecord;
using Refit;

namespace FlashFitClassLibrary.HttpApiProcessor
{
    public interface ICheatmealDataProcessor
    {

        //From API Gateway - Cheatmeal Types
        [Get(path: "/api/cheatmealtype")]
        Task<ApiResponse<List<CheatmealTypeResponse>>> GetAllCheatmealTypes();

        [Get(path: "/api/cheatmealtype/{id}")]
        Task<ApiResponse<CheatmealTypeResponse>> GetCheatmealTypeById(int id);

        [Post(path: "/api/cheatmealtype")]
        Task<ApiResponse<CheatmealTypeCreation>> CreateNewCheatmealType([Body] CheatmealTypeCreation cheatmealType);

        [Put(path: "/api/cheatmealtype")]
        Task<ApiResponse<CheatmealTypeResponse>> UpdateCheatmealType([Body] CheatmealTypeUpdate cheatmealType);

        [Delete(path: "/api/cheatmealtype/{id}")]
        Task<ApiResponse<CheatmealTypeResponse>> DeleteCheatmealById(int id);


        //From API Gateway -> Cheatmeal Record
        [Get(path: "/api/cheatmealrecord/byuser/{email}")]
        Task<ApiResponse<List<CheatmealRecordResponse>>> GetAllChetmealRecordsByEmail(string email);

        [Post(path: "/api/cheatmealrecord")]
        Task<ApiResponse<CheatmealRecordCreation>> CreateNewChetmealRecord([Body] CheatmealRecordCreation workoutRecord);

        [Get(path: "/api/cheatmealrecord/{id}")]
        Task<ApiResponse<CheatmealRecordResponse>> GetChetmealRecordById(int id);

        [Put(path: "/api/cheatmealrecord")]
        Task<ApiResponse<CheatmealRecordResponse>> UpdateChetmealRecord([Body] CheatmealReocrdUpdate workoutRecord);

        [Delete(path: "/api/cheatmealrecord/{id}")]
        Task<ApiResponse<CheatmealRecordResponse>> DeleteChetmealRecord(int id);

        //From Internal Services
        [Get(path: "/cheatmealrecord/byuser/{email}")]
        Task<ApiResponse<IEnumerable<CheatmealRecordResponse>>> GetInternalCheatmealHistoryForUser(string email);


    }
}
