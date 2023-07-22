using FlashFitClassLibrary.Enumz;
using FlashFitClassLibrary.Resources.CheatmealRecord;
using FlashFitClassLibrary.Resources.Report;
using FlashFitClassLibrary.Resources.User;
using FlashFitClassLibrary.Resources.WorkoutRecord;
using FlashFitClassLibrary.Services;
using FlashFitWinFormUI.Services;

namespace FlashFitWinFormUI;

public partial class ReportUserControlForm : UserControl
{

    private readonly ReportService _reportService;

    private readonly UserService _userService;


    public ReportUserControlForm()
    {
        InitializeComponent();
        _reportService = new ReportService();
        _userService = new UserService();

        toDatePicker.MaxDate = DateTime.Now;
        fromDatePicker.MinDate = DateTime.Now.AddDays(-120);
        toDatePicker.MinDate = DateTime.Now.AddDays(-119);
    }


    private async Task setUserData()
    {
        UserResource user = await _userService.getUserByEmail(Program.getLoggedInUser().Email);

        decimal bmi = user.BodyMassIndex;
        HealthStatusEnum healthStatus = (HealthStatusEnum)Enum.Parse(typeof(HealthStatusEnum), user.HeathStatus);



        namePlac.Text = user.Name;
        weightPcl.Text = $"{user.WeightInKiloGrams:F2}";
        bmiPlc.Text = $"{user.BodyMassIndex:F2}";
        healthStatusPlc.Text = healthStatus.ToString();


    }

    private void setupWorkoutListView(List<WorkoutRecordResponse> list)
    {

        if (list.Count == 0)
        {
            MessageBox.Show("No workout record found");
        }

        string[] item = new string[3];
        ListViewItem listItem;
        reportListView.Items.Clear();

        foreach (var i in list)
        {
            item[0] = i.WorkoutDateTime.ToShortDateString();
            item[1] = i.Workout.WorkoutName;
            item[2] = i.WeightAtCompletion.ToString();

            listItem = new ListViewItem(item);
            reportListView.Items.Add(listItem);
        }
    }

    private void setupCheatmealListView(List<CheatmealRecordResponse> list)
    {

        if (list.Count == 0)
        {
            MessageBox.Show("No Cheatmeal record found");
        }
            string[] item = new string[3];
        ListViewItem listItem;
        reportListView.Items.Clear();

        foreach (var x in list)
        {

            item[0] = x.CheatmealAddedDateTime.ToShortDateString();
            item[1] = x.Cheatmeal.CheatmealName;
            item[2] = x.WeightAtRecordTime.ToString();

            listItem = new ListViewItem(item);
            reportListView.Items.Add(listItem);
        }



    }

    private async void getAllRecordButton_Click(object sender, EventArgs e)
    {



        if (reportTypeComboBox.SelectedItem == null)
        {
            MessageBox.Show("Pls select the report type");
            return;
        }


        string? selectedReportType = reportTypeComboBox.SelectedItem.ToString();

        if (selectedReportType == "Cheatmeal")
        {
            List<CheatmealRecordResponse> list = await _reportService.getAllCheatmealsByEmail(Program.getLoggedInUser().Email);
            setupCheatmealListView(list);

        }
        else if (selectedReportType == "Workout")
        {
            List<WorkoutRecordResponse> list = await _reportService.getAllWorkoutssByEmail(Program.getLoggedInUser().Email);
            setupWorkoutListView(list);
        }
        else
        {
            MessageBox.Show("Select Report Type");
            reportTypeComboBox.Focus();
        }
    }

    private async void filterByDateButton_Click(object sender, EventArgs e)
    {
        if (reportTypeComboBox.SelectedItem == null)
        {
            MessageBox.Show("Pls select the report type");
            return;
        }

        DateTime fromDate = fromDatePicker.Value;
        DateTime toDate = toDatePicker.Value;

        if (((int)(toDate - fromDate).TotalDays) <= 0)
        {
            MessageBox.Show("Select a Valid Date Range");
            fromDatePicker.Focus();
            return;
        }



        string? selectedReportType = reportTypeComboBox.SelectedItem.ToString();

        ReportRequest reportRequest = new ReportRequest(
            Program.getLoggedInUser().Email,
            fromDate,
            toDate
            );

        if (selectedReportType == "Cheatmeal")
        {
            List<CheatmealRecordResponse> list = await _reportService.getAllCheatmealsByEmailAndDate(reportRequest);
            setupCheatmealListView(list);

        }
        else if (selectedReportType == "Workout")
        {
            List<WorkoutRecordResponse> list = await _reportService.getAllWorkoutssByEmailAndDate(reportRequest);
            setupWorkoutListView(list);
        }
        else
        {
            MessageBox.Show("Select Report Type");
            reportTypeComboBox.Focus();
        }
    }

    private async void ReportUserControlForm_Load(object sender, EventArgs e)
    {
        await setUserData();
    }
}
