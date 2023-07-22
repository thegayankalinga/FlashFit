using FlashFitClassLibrary.Resources.Workout;
using FlashFitClassLibrary.Resources.WorkoutRecord;
using FlashFitClassLibrary.Services;

namespace FlashFitWinFormUI;

public partial class WorkoutUserControlForm : UserControl
{
    private readonly WorkoutService _workoutService;
    private readonly UserService _userService;
    private readonly WorkoutRecordService _workoutRecordService;

    private bool editButtonClicked = false;


    public WorkoutUserControlForm()
    {
        InitializeComponent();
        _workoutRecordService = new WorkoutRecordService();
        _userService = new UserService();
        _workoutService = new WorkoutService();


        selectWorkoutComboBox.ResetText();
        workedoutDateTimePicker.Value = DateTime.Now;
    }



    //Open up the Add form button
    private void addWorkoutFormButton_Click(object sender, EventArgs e)
    {
        AddWorkoutForm addWorkoutForm = new AddWorkoutForm();
        addWorkoutForm.ShowDialog();
    }

    //Create or Update Button for new or existing record
    private async void saveWorkoutRecordButton_Click(object sender, EventArgs e)
    {
        //Use Edit button saving options
        if (editButtonClicked)
        {

            await updateChangestoWorkoutRecord();
            await setupListView();
            return;
        }


        WorkoutTypeResponse? workoutModel;
        int workoutID;

        int selectedIndex = selectWorkoutComboBox.SelectedIndex;

        if (selectedIndex != -1)
        {
            workoutID = int.Parse(selectWorkoutComboBox.SelectedItem.ToString().Substring(0, 1));
            workoutModel = await _workoutService.getWorkoutById(workoutID);
        }
        else
        {
            MessageBox.Show("Pls select the Workout type");
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
            WorkoutRecordCreation newRecord = new(
                workoutModel.workoutId,
                Program.getLoggedInUser().Email,
                workedoutDateTimePicker.Value,
                weightAtWorkoutNumeric.Value,
                DateTime.UtcNow
                );


            WorkoutRecordCreation createdRecord = await _workoutRecordService.createWorkoutRecord(newRecord);

            if (createdRecord != null)
            {
                MessageBox.Show($"Your workout marked successfully");
                clearForm();
                await setupListView();
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
            MessageBox.Show("Something went wrong");
            return;
        }

    }

    //Load the combobox values
    private async Task<List<string>> generateComboBoxValues()
    {
        List<string> comboBoxLoadList = new List<string>();
        comboBoxLoadList.Add("0 - Select");

        List<WorkoutTypeResponse>? value = await _workoutService.getAllWorkouts().ConfigureAwait(false);


        value.ForEach(model =>
      {
          string combinedValue = $"{model.workoutId} - {model.WorkoutName}";

          comboBoxLoadList.Add(combinedValue);
      });
        return comboBoxLoadList;
    }

    //Setup the List View
    private async Task setupListView()
    {
        List<WorkoutRecordResponse> list = await _workoutRecordService.getWorkoutRecordsByEmail(Program.getLoggedInUser().Email);

        string[] item = new string[5];
        ListViewItem listItem;
        workoutRecordListView.Items.Clear();

        foreach (var i in list)
        {
            item[0] = i.WorkoutRecordId.ToString();
            item[1] = i.Workout.WorkoutName;
            item[2] = i.WorkoutDateTime.ToShortDateString();
            item[3] = i.Workout.CaloryBurnRate.ToString();
            item[4] = i.WeightAtCompletion.ToString();

            listItem = new ListViewItem(item);
            workoutRecordListView.Items.Add(listItem);
        }
    }

    //Form load setup initial values
    private async void WorkoutUserControlForm_Load(object sender, EventArgs e)
    {
        await setupListView();
        selectWorkoutComboBox.Items.AddRange(generateComboBoxValues().Result.ToArray());
        selectWorkoutComboBox.SelectedText = "0 - Select";

    }


    //Set the record for Edit 
    private async void workoutRecordEditButton_Click(object sender, EventArgs e)
    {
        int workoutRecordID;

        if (workoutRecordListView.SelectedItems.Count > 0)
        {
            workoutRecordID = int.Parse(workoutRecordListView.SelectedItems[0].Text);
            WorkoutRecordResponse workoutRecordModel = await _workoutRecordService.getWorkoutRecordById(workoutRecordID);

            if (workoutRecordModel != null)
            {
                string combinedValue = $"{workoutRecordModel.Workout.WorkoutID} - {workoutRecordModel.Workout.WorkoutName}";
                hiddenRecordIDText.Text = workoutRecordModel.WorkoutRecordId.ToString();
                selectWorkoutComboBox.ResetText();
                selectWorkoutComboBox.SelectedText = combinedValue;
                workedoutDateTimePicker.Value = workoutRecordModel.WorkoutDateTime;
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

    //Clear the Form
    private void clearForm()
    {
        hiddenRecordIDText.Clear();
        selectWorkoutComboBox.ResetText();
        selectWorkoutComboBox.SelectedText = "0 - Select";
        workedoutDateTimePicker.Value = DateTime.Now;
        weightAtWorkoutNumeric.Value = 0;
        selectWorkoutComboBox.Focus();
    }

    //Update the selected workout record
    private async Task updateChangestoWorkoutRecord()
    {

        WorkoutTypeResponse workoutModel;

        //int selectedIndex = selectWorkoutComboBox.SelectedIndex;


        WorkoutRecordResponse workoutRecord = await _workoutRecordService.getWorkoutRecordById(int.Parse(hiddenRecordIDText.Text));

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
            workoutModel = await _workoutService.getWorkoutById(workoutID);

            int recordID = int.Parse(hiddenRecordIDText.Text);

            WorkoutRecordUpdate updatedWorkoutRecord = new(
                recordID,
                workoutModel.workoutId,
                Program.getLoggedInUser().Email,
                workedoutDateTimePicker.Value,
                weightAtWorkoutNumeric.Value,
                DateTime.UtcNow
                );


            if (workoutRecord.Equals(updatedWorkoutRecord))
            {
                MessageBox.Show("No changes to update");
                return;
            }
            else
            {
                WorkoutRecordResponse result = await _workoutRecordService.updateWorkoutRecordById(updatedWorkoutRecord);
                if (result != null)
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


    //Delete Workout Record
    private async void workoutRecordDeleteButton_Click(object sender, EventArgs e)
    {
        int workoutRecordID;

        if (workoutRecordListView.SelectedItems.Count > 0)
        {
            workoutRecordID = int.Parse(workoutRecordListView.SelectedItems[0].Text);
            WorkoutRecordResponse recordResponse = await _workoutRecordService.deleteWorkoutRecord(workoutRecordID);


            if (recordResponse != null)
            {
                MessageBox.Show($"Workout Record ID {workoutRecordID} is deleted successfully");
                await setupListView();
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
