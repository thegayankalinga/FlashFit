


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
using FlashFitClassLibrary.InitialData;

namespace FlashFitWinFormUI;

public partial class WorkoutUserControlForm : UserControl
{
    WorkoutService workoutService = new WorkoutService();
    UserService userService = new UserService();
    WorkoutRecordService workoutRecordService = new WorkoutRecordService();
    bool editButtonClicked = false;


    public WorkoutUserControlForm()
    {
        InitializeComponent();
       
        selectWorkoutComboBox.ResetText();
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

        if (editButtonClicked)
        {

            updateChangestoWorkoutRecord();
            setupListView();
            return;
        }



        WorkoutRecordModel workoutRecordModel = new WorkoutRecordModel();
        WorkoutModel? workoutModel = new WorkoutModel();
        int workoutID;

        int selectedIndex = selectWorkoutComboBox.SelectedIndex;

        if (selectedIndex != -1)
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

        if (weightAtWorkoutNumeric.Value <= 0)
        {
            MessageBox.Show("Pls enter the current weight");
            weightAtWorkoutNumeric.Focus();
            return;
        }

        if (workoutModel != null)
        {
            workoutRecordModel.WorkoutRecordId = TemporaryDataStore.WorkoutRecordIDCounter + 1;
            workoutRecordModel.Workout = workoutModel;
            workoutRecordModel.UserEmail = Program.getLoggedInUser().Email;
            workoutRecordModel.WorkedoutDateTime = workedoutDateTimePicker.Value;
            workoutRecordModel.WeightAtCompletion = weightAtWorkoutNumeric.Value;

            userService.updateUserWeight(workoutRecordModel.WeightAtCompletion, workoutRecordModel.UserEmail);
            TemporaryDataStore.workoutRecords.Add(workoutRecordModel);
            MessageBox.Show($"Your workout marked successfully");
            TemporaryDataStore.CheatmealRecordIdCounter += 1;
            clearForm();
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
        comboBoxLoadList.Add("0 - Select");
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
            item[2] = i.WorkedoutDateTime.ToShortDateString();
            item[3] = i.Workout.CaloryBurnRate.ToString();
            item[4] = i.WeightAtCompletion.ToString();

            listItem = new ListViewItem(item);
            workoutRecordListView.Items.Add(listItem);
        }
    }

    private void WorkoutUserControlForm_Load(object sender, EventArgs e)
    {
        TemporaryDataStore.WorkoutRecordIDCounter = TemporaryDataStore.workoutRecords.Count + 1;
        setupListView();
        selectWorkoutComboBox.SelectedText = "0 - Select";

    }

    private void workoutRecordEditButton_Click(object sender, EventArgs e)
    {
        int workoutRecordID;

        if (workoutRecordListView.SelectedItems.Count > 0)
        {
            workoutRecordID = int.Parse(workoutRecordListView.SelectedItems[0].Text);
            WorkoutRecordModel workoutRecordModel = workoutRecordService.getWorkoutRecordById(workoutRecordID);

            if (workoutRecordModel != null)
            {
                string combinedValue = $"{workoutRecordModel.Workout.WorkoutID} - {workoutRecordModel.Workout.WorkoutName}";
                hiddenRecordIDText.Text = workoutRecordModel.WorkoutRecordId.ToString();
                selectWorkoutComboBox.ResetText();
                selectWorkoutComboBox.SelectedText = combinedValue;
                workedoutDateTimePicker.Value = workoutRecordModel.WorkedoutDateTime;
                weightAtWorkoutNumeric.Value = workoutRecordModel.WeightAtCompletion;
                editButtonClicked = true;
                selectWorkoutComboBox.Focus();
                selectWorkoutComboBox.DroppedDown = true;
            }
            else
            {
                MessageBox.Show("Could not found workout");
            }
        }
        else
        {
            MessageBox.Show("Please select itme to edit");
        }
    }

    private void clearForm()
    {
        hiddenRecordIDText.Clear();
        selectWorkoutComboBox.ResetText();
        selectWorkoutComboBox.SelectedText = "0 - Select";
        workedoutDateTimePicker.Value = DateTime.Now;
        weightAtWorkoutNumeric.Value = 0;
        selectWorkoutComboBox.Focus();
    }

    private void updateChangestoWorkoutRecord()
    {
        WorkoutRecordModel updatedWorkoutRecord = new WorkoutRecordModel();
        WorkoutModel workoutModel = new WorkoutModel();

        //int selectedIndex = selectWorkoutComboBox.SelectedIndex;


        WorkoutRecordModel workoutRecord = workoutRecordService.getWorkoutRecordById(int.Parse(hiddenRecordIDText.Text));

        if (workoutRecord != null)
        {
            if (selectWorkoutComboBox.SelectedItem == null)
            {
                MessageBox.Show("Reselect the Workout");
                selectWorkoutComboBox.Focus();
                selectWorkoutComboBox.DroppedDown = true;
                return;
            }

            int workoutID = int.Parse(selectWorkoutComboBox.SelectedItem.ToString().Substring(0, 1));
            workoutModel = workoutService.getWorkoutById(workoutID);

            updatedWorkoutRecord.WorkoutRecordId = int.Parse(hiddenRecordIDText.Text);
            updatedWorkoutRecord.Workout = workoutModel;
            updatedWorkoutRecord.WorkedoutDateTime = workedoutDateTimePicker.Value;
            updatedWorkoutRecord.UserEmail = Program.getLoggedInUser().Email;
            updatedWorkoutRecord.WeightAtCompletion = weightAtWorkoutNumeric.Value;

            if (workoutRecord.Equals(updatedWorkoutRecord))
            {
                MessageBox.Show("No changes to update");
                return;
            }
            else
            {
                bool result = workoutRecordService.updateWorkoutRecordById(updatedWorkoutRecord);
                if (result)
                {
                    MessageBox.Show($" Workout Record ID {workoutRecord.WorkoutRecordId} updated successfully");
                    editButtonClicked = false;
                    clearForm();
                }
                else
                {
                    MessageBox.Show("Something went wrong, try later");
                }
            }
        }
        else
        {
            MessageBox.Show("Pls select the Workout");
            selectWorkoutComboBox.Focus();
            return;
        }



    }

    private void workoutRecordDeleteButton_Click(object sender, EventArgs e)
    {
        int workoutRecordID;

        if (workoutRecordListView.SelectedItems.Count > 0)
        {
            workoutRecordID = int.Parse(workoutRecordListView.SelectedItems[0].Text);

            if (workoutRecordService.deleteWorkoutRecord(workoutRecordID))
            {
                MessageBox.Show($"Workout Record ID {workoutRecordID} is deleted successfully");
                setupListView();
                return;
            }
            else
            {
                MessageBox.Show("Something went wrong");
                return;
            }
        }
        else
        {
            MessageBox.Show("Select Item to Delete");
            return;
        }

    }
}
