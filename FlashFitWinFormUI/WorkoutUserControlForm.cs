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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FlashFitClassLibrary.Services;
using Microsoft.VisualBasic;

namespace FlashFitWinFormUI;

public partial class WorkoutUserControlForm : UserControl
{
    WorkoutService workoutService = new WorkoutService();



    public WorkoutUserControlForm()
    {
        InitializeComponent();
        TemporaryDataStore.WorkoutRecordIDCounter = TemporaryDataStore.workoutRecords.Count;
        selectWorkoutComboBox.Items.AddRange(generateComboBoxValues().ToArray());
        workedoutDateTimePicker.Value = DateTime.Now;
    }



    private void addWorkoutFormButton_Click(object sender, EventArgs e)
    {
        AddWorkoutForm addWorkoutForm = new AddWorkoutForm();
        addWorkoutForm.ShowDialog();
    }


    private void saveWorkoutRecordButton_Click(object sender, EventArgs e)
    {
        WorkoutRecordModel workoutRecordModel = new WorkoutRecordModel();
        WorkoutModel? workoutModel = new WorkoutModel();
        int workoutID;

        if (selectWorkoutComboBox.SelectedItem != null)
        {
            workoutID = int.Parse(selectWorkoutComboBox.SelectedItem.ToString().Substring(0, 1));
            workoutModel = workoutService.getWorkoutById(workoutID);
        }
        else
        {
            MessageBox.Show("Pls select the Workout");
            selectWorkoutComboBox.Focus();
            return;
        }

        if (workoutModel != null)
        {
            workoutRecordModel.WorkoutRecordId = TemporaryDataStore.workoutRecords.Count + 1;
            workoutRecordModel.Workout = workoutModel;
            workoutRecordModel.UserEmail = Program.getLoggedInUser().Email;
            workoutRecordModel.WorkedoutDateTime = workedoutDateTimePicker.Value;
            workoutRecordModel.WeightAtCompletion = weightAtWorkoutNumeric.Value;

            TemporaryDataStore.workoutRecords.Add(workoutRecordModel);
            MessageBox.Show($"Your workout marked successfully");
            setupListView();
            return;
        }
        else
        {
            MessageBox.Show("Something went wrong");
            return;
        }







    }

    private List<string> generateComboBoxValues()
    {
        List<string> comboBoxLoadList = new List<string>();

        TemporaryDataStore.workoutModels.ForEach(model =>
        {
            string combinedValue = $"{model.WorkoutID} - {model.WorkoutName}";
            comboBoxLoadList.Add(combinedValue);
        });
        return comboBoxLoadList;
    }

    private void setupListView()
    {
        List<WorkoutRecordModel> list = TemporaryDataStore.workoutRecords;

        string[] item = new string[5];
        ListViewItem listItem;
        workoutRecordListView.Items.Clear();

        foreach (var i in list)
        {
            item[0] = i.WorkoutRecordId.ToString();
            item[1] = i.Workout.WorkoutName;
            item[2] = i.WorkedoutDateTime.ToString("yyyy-mmm-dd");
            item[3] = i.Workout.CaloryBurnRate.ToString();
            item[4] = i.WeightAtCompletion.ToString();


            listItem = new ListViewItem(item);
            workoutRecordListView.Items.Add(listItem);
        }
    }

    private void WorkoutUserControlForm_Load(object sender, EventArgs e)
    {
        setupListView();
    }
}
