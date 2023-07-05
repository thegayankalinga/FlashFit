using FlashFitClassLibrary;
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

    public AddWorkoutForm()
    {
        InitializeComponent();
    }

    private void AddWorkoutForm_Load(object sender, EventArgs e)
    {
        workoutTypeComboBox.DataSource = Enum.GetValues(typeof(WorkoutTypeEnum));
        TemporaryDataStore.WorkoutIDCounter += 1;
        workoutIdText.Text = (TemporaryDataStore.WorkoutIDCounter).ToString();
    }

    private void saveWorkoutButton_Click(object sender, EventArgs e)
    {
        WorkoutModel model = new WorkoutModel();

        model.WorkoutID = int.Parse(workoutIdText.Text);
        model.WorkoutName = workoutNameText.Text;
        model.WorkoutType = (WorkoutTypeEnum)workoutTypeComboBox.SelectedItem;
        model.CaloryBurnRate = caloriesBurnRateNumeric.Value;

        WorkoutService workoutService = new WorkoutService();
        if (workoutService.createWorkout(model))
        {
            MessageBox.Show($"Workout {model.WorkoutName} saved successfully");
        }
        this.Close();
        //TODO: Get the main form to focus

    }
}
