using FlashFitClassLibrary.Resources.CheatmealRecord;
using FlashFitClassLibrary.Resources.Prediction;
using FlashFitClassLibrary.Resources.Report;
using FlashFitClassLibrary.Resources.WorkoutRecord;
using Refit;

namespace FlashFitClassLibrary.HttpApiProcessor;

public interface IUtilityServiceDataProcessor
{
    //From API Gateway - Prediction
    [Post(path: "/api/predication")]
    Task<ApiResponse<PredictionResponse>> PredictHealthStatus([Body] PredictionRequest predictionRequest);


    //From API Gateway - Report 
    [Get(path: "/api/report/cheatmeal/{email}")]
    Task<ApiResponse<IEnumerable<CheatmealRecordResponse>>> GetCheatmealReportByEmail(string email);

    [Get(path: "/api/report/workout/{email}")]
    Task<ApiResponse<IEnumerable<WorkoutRecordResponse>>> GetWokroutReportByEmail(string email);

    [Post(path: "/api/report/workout/daterange")]
    Task<ApiResponse<IEnumerable<WorkoutRecordResponse>>> GetWorkoutReportByEmailAndDate([Body] ReportRequest request);

    [Post(path: "/api/report/cheatmeal/daterange")]
    Task<ApiResponse<IEnumerable<CheatmealRecordResponse>>> GetCheatmealReportByEmailAndDate([Body] ReportRequest request);

}