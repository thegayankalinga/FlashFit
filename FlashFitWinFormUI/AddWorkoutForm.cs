using FlashFitClassLibrary;
using FlashFitClassLibrary.InitialData;
using FlashFitClassLibrary.Models;
using FlashFitClassLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashFitWinFormUI;

public partial class AddWorkoutForm : Form
{
    WorkoutService workoutService = new WorkoutService();
    bool editButtonClicked = false;
    public AddWorkoutForm()
    {
        InitializeComponent();

    }

    private void AddWorkoutForm_Load(object sender, EventArgs e)
    {
        workoutTypeComboBox.DataSource = Enum.GetValues(typeof(WorkoutTypeEnum));
        TemporaryDataStore.WorkoutIDCounter = TemporaryDataStore.workoutModels.Count + 1;
        setupListView();

    }

    private void saveWorkoutButton_Click(object sender, EventArgs e)
    {

        if (editButtonClicked)
        {
            updateChangesToWorkoutModel();
            clearForm();
            setupListView();
            return;
        }

        if (workoutTypeComboBox.SelectedValue == null)
        {
            MessageBox.Show("Please select the workout type");
            workoutTypeComboBox.Focus();
            return;
        }
        else if (workoutNameText.Text == "")
        {
            MessageBox.Show("Please enter the workout name");
            workoutNameText.Focus();
            return;
        }

        WorkoutModel model = new WorkoutModel();

        model.WorkoutID = TemporaryDataStore.WorkoutIDCounter + 1;
        model.WorkoutName = workoutNameText.Text;
        model.WorkoutType = (WorkoutTypeEnum)workoutTypeComboBox.SelectedItem;
        model.CaloryBurnRate = caloriesBurnRateNumeric.Value;

        WorkoutService workoutService = new WorkoutService();
        if (workoutService.createWorkout(model))
        {
            MessageBox.Show($"Workout {model.WorkoutName} saved successfully");
            TemporaryDataStore.WorkoutIDCounter += 1;
            setupListView();
            clearForm();
            return;
        }

       

    }

    private void setupListView()
    {
        List<WorkoutModel> list = TemporaryDataStore.workoutModels;

        string[] item = new string[4];
        ListViewItem listItem;
        workoutListView.Items.Clear();

        foreach (var i in list)
        {
            item[0] = i.WorkoutID.ToString();
            item[1] = i.WorkoutName;
            item[2] = i.WorkoutType.ToString();
            item[3] = i.CaloryBurnRate.ToString();


            listItem = new ListViewItem(item);
            workoutListView.Items.Add(listItem);
        }
    }

    private void deleteWorkoutButton_Click(object sender, EventArgs e)
    {
        int workoutID;

        if (workoutListView.SelectedItems.Count > 0)
        {
            workoutID = int.Parse(workoutListView.SelectedItems[0].Text);
        }
        else
        {
            MessageBox.Show("Select Item to Delete");
            return;
        }

        if (workoutService.deleteWorkoutById(workoutID))
        {
            MessageBox.Show($"Workout ID {workoutID} is deleted successfully");
            setupListView();
        }
        else
        {
            MessageBox.Show("Something went wrong");
        }
    }

    private void clearForm()
    {
        hiddenWorkoutIDText.Clear();
        workoutNameText.Clear();
        caloriesBurnRateNumeric.Value = 0;
        workoutNameText.Focus();
    }

    private void editWorkoutButton_Click(object sender, EventArgs e)
    {
        int workoutID;

        if (workoutListView.SelectedItems.Count > 0)
        {
            workoutID = int.Parse(workoutListView.SelectedItems[0].Text);
            WorkoutModel workoutModel = workoutService.getWorkoutById(workoutID);
            if (workoutModel != null)
            {
                hiddenWorkoutIDText.Text = workoutID.ToString();
                workoutNameText.Text = workoutModel.WorkoutName;
                workoutTypeComboBox.SelectedItem = workoutModel.WorkoutType;
                caloriesBurnRateNumeric.Value = workoutModel.CaloryBurnRate;
                editButtonClicked = true;
            }
            else
            {
                MessageBox.Show("Something weng wrong");
            }
        }
        else
        {
            MessageBox.Show("Please select itme to edit");
        }

    }

    private void updateChangesToWorkoutModel()
    {
        WorkoutModel updatedWorkoutModel = new WorkoutModel();
        WorkoutModel workoutModel = workoutService.getWorkoutById(int.Parse(hiddenWorkoutIDText.Text));

        updatedWorkoutModel.WorkoutID = int.Parse(hiddenWorkoutIDText.Text);
        updatedWorkoutModel.WorkoutName = workoutNameText.Text;
        updatedWorkoutModel.WorkoutType = (WorkoutTypeEnum)workoutTypeComboBox.SelectedItem;
        updatedWorkoutModel.CaloryBurnRate = caloriesBurnRateNumeric.Value;

        if (workoutModel.Equals(updatedWorkoutModel))
        {
            MessageBox.Show("No changes to update");
            return;
        }
        else
        {
            bool result = workoutService.updateWorkoutById(updatedWorkoutModel);
            if (result)
            {
                MessageBox.Show($" {workoutModel.WorkoutID} updated successfully");
                editButtonClicked = false;
            }
            else
            {
                MessageBox.Show("Something went wrong, try later");
            }
        }
    }
}
