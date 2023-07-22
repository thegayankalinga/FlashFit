using FlashFitClassLibrary.Resources.Cheatmeal;
using FlashFitClassLibrary.Resources.CheatmealRecord;
using FlashFitClassLibrary.Services;

namespace FlashFitWinFormUI;
public partial class CheatmealUserControlForm : UserControl
{

    private readonly CheatmealService _cheatmealService;
    private readonly CheatmealRecoredService _cheatmealRecoredService;
    bool editButtonClicked = false;


    public CheatmealUserControlForm()
    {
        InitializeComponent();
        _cheatmealService = new();
        _cheatmealRecoredService = new();

        selectCheatmealComboBox.ResetText();

        cheatmealDateTimePicker.Value = DateTime.Now;
    }

    private async Task setupListView()
    {
        List<CheatmealRecordResponse> list = await _cheatmealRecoredService.getCheatmealRcordsByEmail(Program.getLoggedInUser().Email);

        if (list.Count <= 0)
        {
            MessageBox.Show("No records found");
            return;
        }

        string[] item = new string[5];
        ListViewItem listItem;
        cheatmealRecordListView.Items.Clear();

        foreach (var x in list)
        {
            item[0] = x.CheatmealRecordId.ToString();
            item[1] = x.Cheatmeal.CheatmealName;
            item[2] = x.CheatmealAddedDateTime.ToString();
            item[3] = x.Cheatmeal.CheatCalorieGain.ToString();
            item[4] = x.WeightAtRecordTime.ToString();

            listItem = new ListViewItem(item);
            cheatmealRecordListView.Items.Add(listItem);
        }



    }
    private void clearForm()
    {
        hiddenCheatmealRecordIDText.Clear();
        selectCheatmealComboBox.ResetText();
        selectCheatmealComboBox.SelectedText = "0 - Select";
        cheatmealDateTimePicker.Value = DateTime.Now;
        weightAtCheatmealNumeric.Value = 0;
        selectCheatmealComboBox.Focus();
    }
    private async Task updateChangestoCheatmealRecord()
    {
        CheatmealReocrdUpdate updatedRecordModel;
        CheatmealTypeResponse? cheatmealModel;

        if (selectCheatmealComboBox.SelectedItem == null)
        {
            MessageBox.Show("Reselect the Workout");
            selectCheatmealComboBox.Focus();
            selectCheatmealComboBox.DroppedDown = true;
            return;
        }

        int cheatmealID = int.Parse(selectCheatmealComboBox.SelectedItem.ToString().Substring(0, 1));
        if (cheatmealID == 0)
        {
            MessageBox.Show("Invalid Cheatmeal Type ID");
            return;

        }
        cheatmealModel = await _cheatmealService.getCheatmealById(cheatmealID);

        if (cheatmealModel == null)
        {
            MessageBox.Show("Could not found valid Cheatmeal type");
            return;
        }

        updatedRecordModel = new CheatmealReocrdUpdate(
            int.Parse(hiddenCheatmealRecordIDText.Text),
            cheatmealModel.Id,
            Program.getLoggedInUser().Email,
            cheatmealDateTimePicker.Value,
            weightAtCheatmealNumeric.Value,
            DateTime.UtcNow

            );

        if (updatedRecordModel == null)
        {
            MessageBox.Show("No changes to update");
            return;
        }
        else
        {
            CheatmealRecordResponse? result = await _cheatmealRecoredService.updateCheatmealRecord(updatedRecordModel);
            if (result != null)
            {
                MessageBox.Show($" Cheatmeal Record ID {result.CheatmealRecordId} updated successfully");
                editButtonClicked = false;
                clearForm();
            }
            else
            {
                MessageBox.Show("Something went wrong, try later");
            }
        }
    }

    private async Task<List<string>> generateComboBoxValues()
    {
        List<string> comboBoxLoadList = new List<string>();
        comboBoxLoadList.Add("0 - Select");

        List<CheatmealTypeResponse> typeList = await _cheatmealService.getAllCheatmeal();

        typeList.ForEach(model =>
        {
            string combinedValue = $"{model.Id} - {model.Name}";
            comboBoxLoadList.Add(combinedValue);
        });
        return comboBoxLoadList;
    }


    //From Events
    private void addCheatMealButton_Click(object sender, EventArgs e)
    {
        AddCheatmealForm addCheatmealForm = new AddCheatmealForm();
        addCheatmealForm.ShowDialog();
    }

    private async void CheatmealUserControlForm_Load(object sender, EventArgs e)
    {
        await setupListView();

        selectCheatmealComboBox.Items.AddRange((await generateComboBoxValues()).ToArray());
        selectCheatmealComboBox.SelectedText = "0 - Select";
    }

    private async void workoutRecordDeleteButton_Click(object sender, EventArgs e)
    {
        int cheatmealID;

        if (cheatmealRecordListView.SelectedItems.Count > 0)
        {
            cheatmealID = int.Parse(cheatmealRecordListView.SelectedItems[0].Text);
            CheatmealRecordResponse? recordResponse = await _cheatmealRecoredService.deleteCheatmealRecord(cheatmealID);
            if (recordResponse != null)
            {
                MessageBox.Show($"Cheatmeal Record ID {recordResponse} is deleted successfully");
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

    private async void workoutRecordEditButton_Click(object sender, EventArgs e)
    {
        int cheatmealID;

        if (cheatmealRecordListView.SelectedItems.Count > 0)
        {
            cheatmealID = int.Parse(cheatmealRecordListView.SelectedItems[0].Text);
            CheatmealRecordResponse? model = await _cheatmealRecoredService.getCheatmealRecordById(cheatmealID);

            if (model != null)
            {
                string combinedText = $"{model.Cheatmeal.CheatmealId} - {model.Cheatmeal.CheatmealName}";
                hiddenCheatmealRecordIDText.Text = model.CheatmealRecordId.ToString();
                selectCheatmealComboBox.ResetText();
                selectCheatmealComboBox.SelectedText = combinedText;
                cheatmealDateTimePicker.Value = model.CheatmealAddedDateTime;
                weightAtCheatmealNumeric.Value = model.WeightAtRecordTime;
                editButtonClicked = true;
                selectCheatmealComboBox.Focus();
                selectCheatmealComboBox.DroppedDown = true;
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

    private async void saveCheatmealRecordButton_Click(object sender, EventArgs e)
    {
        if (editButtonClicked)
        {
            await updateChangestoCheatmealRecord();
            await setupListView();
            return;
        }

        CheatmealRecordCreation cheatmealRecordModel;
        CheatmealTypeResponse? cheatmealModel;
        int cheatmealID;

        int selectedIndex = selectCheatmealComboBox.SelectedIndex;

        if (selectedIndex != -1)
        {
            cheatmealID = int.Parse(selectCheatmealComboBox.SelectedItem.ToString().Substring(0, 1));

            if (cheatmealID < 0)
            {
                MessageBox.Show("Pls select a valid cheatmeael type");
                selectCheatmealComboBox.Focus();
                return;
            }

            cheatmealModel = await _cheatmealService.getCheatmealById(cheatmealID);

            if (cheatmealModel == null)
            {
                MessageBox.Show("Could not find the cheatmeal type, aborting reocrd creation");
                return;
            }
        }
        else
        {
            MessageBox.Show("Pls select the Cheatmeal");
            selectCheatmealComboBox.Focus();
            return;
        }

        if (weightAtCheatmealNumeric.Value <= 0)
        {
            MessageBox.Show("Pls enter the current weight");
            weightAtCheatmealNumeric.Focus();
            return;
        }


        if (cheatmealModel != null)
        {
            cheatmealRecordModel = new CheatmealRecordCreation(
                cheatmealModel.Id,
                Program.getLoggedInUser().Email,
                weightAtCheatmealNumeric.Value,
                cheatmealDateTimePicker.Value,
                DateTime.UtcNow

                );


            CheatmealRecordCreation? result = await _cheatmealRecoredService.createCheatmealRecord(cheatmealRecordModel);

            if (result != null)
            {
                MessageBox.Show($"Your workout record saved successfully");
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
}
