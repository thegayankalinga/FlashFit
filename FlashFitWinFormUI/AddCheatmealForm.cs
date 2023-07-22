using FlashFitClassLibrary.InitialData;
using FlashFitClassLibrary.Resources.Cheatmeal;
using FlashFitClassLibrary.Services;

namespace FlashFitWinFormUI;

public partial class AddCheatmealForm : Form
{

    CheatmealService _cheatmealService;
    bool editButtonClicked = false;

    public AddCheatmealForm()
    {
        InitializeComponent();
        _cheatmealService = new CheatmealService();
    }

    private async void AddCheatmealForm_Load(object sender, EventArgs e)
    {

        await setupListView();
    }

    //Utalitty Methods
    private async Task setupListView()
    {
        List<CheatmealTypeResponse> list = await _cheatmealService.getAllCheatmeal();

        if(list == null)
        {
            MessageBox.Show("No Cheatmeal found, lets add something");
            return;
        }

        string[] item = new string[3];
        ListViewItem listItem;
        cheatmealListView.Items.Clear();

        list.ForEach(i =>
        {
            item[0] = i.Id.ToString();
            item[1] = i.Name;
            item[2] = i.CheatmealCaloryGain.ToString();

            listItem = new ListViewItem(item);
            cheatmealListView.Items.Add(listItem);

        });
    }
    private void clearForm()
    {
        cheatmealNameText.Clear();
        hiddenCheatmealIDText.Clear();
        caloriesGainRateNumeric.Value = 0;
    }
    private async Task updateChangesToCheatmealModel()
    {
        CheatmealTypeUpdate udpatedCheatmealModel;

        udpatedCheatmealModel = new CheatmealTypeUpdate(
            int.Parse(hiddenCheatmealIDText.Text),
            cheatmealNameText.Text,
            caloriesGainRateNumeric.Value,
            DateTime.UtcNow
            );

        if (udpatedCheatmealModel == null)
        {
            MessageBox.Show("No changes to update");
            return;
        }
        else
        {
            CheatmealTypeResponse? result = await _cheatmealService.updateCheatmealById(udpatedCheatmealModel);

            if (result != null)
            {
                MessageBox.Show($" {result.Id} updated successfully");
                editButtonClicked = false;
            }
            else
            {
                MessageBox.Show("Something went wrong, try later");
            }
        }

    }


    //Buttons 
    private async void saveCheatmealButton_Click(object sender, EventArgs e)
    {
        //add edit function here
        if (editButtonClicked)
        {
            await updateChangesToCheatmealModel();
            clearForm();
            await setupListView();
            return;
        }

        if (cheatmealNameText.Text.Length < 3)
        {
            MessageBox.Show("Pls enter valid cheat meal name");
            cheatmealNameText.Focus();
            return;
        }

        CheatmealTypeCreation cheatmealModel = new(
            cheatmealNameText.Text,
            caloriesGainRateNumeric.Value,
            DateTime.UtcNow
            );

        CheatmealTypeCreation? result = await _cheatmealService.createCheatmealType(cheatmealModel);
        
        if (result != null)
        {
            MessageBox.Show($"Workout {result.Name} saved successfully");
            await setupListView();
            clearForm();
            return;
        }
        else
        {
            MessageBox.Show($"Could not save, somthing went wrong");
            return;
        }
    }

    private async void deleteCheatmealButton_Click(object sender, EventArgs e)
    {
        int cheatmealID;

        if (cheatmealListView.SelectedItems.Count > 0)
        {
            cheatmealID = int.Parse(cheatmealListView.SelectedItems[0].Text);
            CheatmealTypeResponse? result = await _cheatmealService.deletecheatmealById(cheatmealID);
            
            if (result != null)
            {
                MessageBox.Show($"Cheatmeal ID {result.Name} is deleted successfully");
                await setupListView();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
        else
        {
            MessageBox.Show("Select Item to Delete");
            return;
        }
    }

    private async void editCheatmealButton_Click(object sender, EventArgs e)
    {
        int cheatmealID;

        if (cheatmealListView.SelectedItems.Count > 0)
        {
            cheatmealID = int.Parse(cheatmealListView.SelectedItems[0].Text);
            CheatmealTypeResponse? cheatmealModel = await _cheatmealService.getCheatmealById(cheatmealID);
            if (cheatmealModel != null)
            {
                hiddenCheatmealIDText.Text = cheatmealID.ToString();
                cheatmealNameText.Text = cheatmealModel.Name;
                caloriesGainRateNumeric.Value = cheatmealModel.CheatmealCaloryGain;
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
}
