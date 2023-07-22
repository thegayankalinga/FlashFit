namespace FlashFitClassLibrary.Resources.Report
{
    public sealed record ReportRequest(
        string email,
        DateTime fromDate,
        DateTime toDate)
    {
    }
}
