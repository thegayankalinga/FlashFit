using FlashFitClassLibrary.Models;
using FlashFitClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlashFitClassLibrary.Services;
using FlashFitClassLibrary.InitialData;

namespace FlashFitWinFormUI;

public partial class ReportUserControlForm : UserControl
{

    WorkoutRecordService workoutRecordService = new WorkoutRecordService();
    CheatmealRecoredService cheatmealRecoredService = new CheatmealRecoredService();
    string email = Program.getLoggedInUser().Email;



    UserService userService = new UserService();
    PredictionService predictiveService = new PredictionService();


    public ReportUserControlForm()
    {
        InitializeComponent();
        setUserData();
        toDatePicker.MaxDate = DateTime.Now;
        fromDatePicker.MinDate = DateTime.Now.AddDays(-120);
        toDatePicker.MinDate = DateTime.Now.AddDays(-119);
    }


    private void setUserData()
    {
        UserProfileModel userProfile = userService.getUserByEmail(email);
        namePlac.Text = userProfile.Name;
        weightPcl.Text = $"{userProfile.WeightInKiloGrams:F2}";
        bmiPlc.Text = $"{userService.calculateAndUpdateBMI(email):F2}";
        healthStatusPlc.Text = predictiveService.getCurrentHealthStatus(email, userProfile.WeightInKiloGrams).ToString();


    }

    private void setupWorkoutListView(List<WorkoutRecordModel> list)
    {


        string[] item = new string[3];
        ListViewItem listItem;
        reportListView.Items.Clear();

        foreach (var i in list)
        {
            item[0] = i.WorkedoutDateTime.ToShortDateString();
            item[1] = i.Workout.WorkoutName;
            item[2] = i.WeightAtCompletion.ToString();

            listItem = new ListViewItem(item);
            reportListView.Items.Add(listItem);
        }
    }

    private void setupCheatmealListView(List<CheatmealRecordModel> list)
    {
        string[] item = new string[3];
        ListViewItem listItem;
        reportListView.Items.Clear();

        foreach (var x in list)
        {

            item[0] = x.CheatmealAddedDateTime.ToShortDateString();
            item[1] = x.Cheatmeal.CheatmealName;
            item[2] = x.WeightAtMealRecordTime.ToString();

            listItem = new ListViewItem(item);
            reportListView.Items.Add(listItem);
        }



    }

    private void getAllRecordButton_Click(object sender, EventArgs e)
    {



        if (reportTypeComboBox.SelectedItem == null)
        {
            MessageBox.Show("Pls select the report type");
            return;
        }


        string selectedReportType = reportTypeComboBox.SelectedItem.ToString();

        if (selectedReportType == "Cheatmeal")
        {
            List<CheatmealRecordModel> list = TemporaryDataStore.cheatmealRecords;
            setupCheatmealListView(list);

        }
        else if (selectedReportType == "Workout")
        {
            List<WorkoutRecordModel> list = TemporaryDataStore.workoutRecords;
            setupWorkoutListView(list);
        }
        else
        {
            MessageBox.Show("Select Report Type");
            reportTypeComboBox.Focus();
        }
    }

    private void filterByDateButton_Click(object sender, EventArgs e)
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
        }



        string selectedReportType = reportTypeComboBox.SelectedItem.ToString();

        if (selectedReportType == "Cheatmeal")
        {
            List<CheatmealRecordModel> list = cheatmealRecoredService.getCheatmealRecordsByEmailAndDateRange(email, fromDate, toDate);
            setupCheatmealListView(list);

        }
        else if (selectedReportType == "Workout")
        {
            List<WorkoutRecordModel> list = workoutRecordService.getWorkoutRecordsByEmailAndDateRange(email, fromDate, toDate);
            setupWorkoutListView(list);
        }
        else
        {
            MessageBox.Show("Select Report Type");
            reportTypeComboBox.Focus();
        }
    }
}
