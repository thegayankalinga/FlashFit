using FlashFitClassLibrary;
using FlashFitClassLibrary.Resources.Workout;
using FlashFitClassLibrary.Services;

namespace FlashFitWinFormUI;

public partial class AddWorkoutForm : Form
{
    private readonly WorkoutService _workoutService;
    bool editButtonClicked = false;

    public AddWorkoutForm()
    {
        InitializeComponent();
        _workoutService = new WorkoutService();

    }

    private async void AddWorkoutForm_Load(object sender, EventArgs e)
    {
        workoutTypeComboBox.DataSource = Enum.GetValues(typeof(WorkoutTypeEnum));
        await setupListView();

    }

    private async void saveWorkoutButton_Click(object sender, EventArgs e)
    {

        if (editButtonClicked)
        {
            await updateChangesToWorkoutModel();
            clearForm();
            await setupListView();
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

        WorkoutTypeCreation model = new WorkoutTypeCreation(
             workoutNameText.Text,
             (WorkoutTypeEnum)workoutTypeComboBox.SelectedItem,
             caloriesBurnRateNumeric.Value,
             DateTime.UtcNow
             );

        WorkoutTypeCreation? createdWorkout = await _workoutService.createWorkout(model);

        if (createdWorkout != null)
        {
            MessageBox.Show($"Workout {model.WorkoutName} saved successfully");
            await setupListView();
            clearForm();
            return;
        }



    }

    private async Task setupListView()
    {
        List<WorkoutTypeResponse>? list = await _workoutService.getAllWorkouts();

        string[] item = new string[4];
        ListViewItem listItem;
        workoutListView.Items.Clear();

        if(list != null)
        {
            foreach (var i in list)
            {
                item[0] = i.workoutId.ToString();
                item[1] = i.WorkoutName;
                item[2] = i.WorkoutType.ToString();
                item[3] = i.CaloryBurnRate.ToString();


                listItem = new ListViewItem(item);
                workoutListView.Items.Add(listItem);
            }
        }
 
    }

    private async void deleteWorkoutButton_Click(object sender, EventArgs e)
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

        WorkoutTypeResponse? workoutTypeResponse = await _workoutService.deleteWorkoutById(workoutID);
        if (workoutTypeResponse != null)
        {
            MessageBox.Show($"Workout ID {workoutID} is deleted successfully");
            await setupListView();
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
            WorkoutTypeResponse workoutModel = _workoutService.getWorkoutById(workoutID).Result;
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

    private async Task updateChangesToWorkoutModel()
    {

        WorkoutTypeUpdate updatedWorkoutModel = new(
            int.Parse(hiddenWorkoutIDText.Text),
            workoutNameText.Text,
            (WorkoutTypeEnum)workoutTypeComboBox.SelectedItem,
            caloriesBurnRateNumeric.Value,
            DateTime.UtcNow
            );

        if (updatedWorkoutModel == null)
        {
            MessageBox.Show("No changes to update");
            return;
        }
        else
        {
            WorkoutTypeResponse? result = await _workoutService.updateWorkoutById(updatedWorkoutModel);
            if (result != null)
            {
                MessageBox.Show($" {updatedWorkoutModel.workoutId} updated successfully");
                editButtonClicked = false;
            }
            else
            {
                MessageBox.Show("Something went wrong, try later");
            }
        }
    }
}
