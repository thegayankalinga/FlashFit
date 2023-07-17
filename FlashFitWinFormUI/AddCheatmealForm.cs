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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashFitWinFormUI;

public partial class AddCheatmealForm : Form
{

    CheatmealService cheatmealService = new CheatmealService();
    bool editButtonClicked = false;

    public AddCheatmealForm()
    {
        InitializeComponent();
    }

    private void AddCheatmealForm_Load(object sender, EventArgs e)
    {
        TemporaryDataStore.CheatmealIDCounter = TemporaryDataStore.cheatmealModels.Count + 1;
        setupListView();
    }

    //Utalitty Methods
    private void setupListView()
    {
        List<CheatmealModel> list = TemporaryDataStore.cheatmealModels;

        string[] item = new string[3];
        ListViewItem listItem;
        cheatmealListView.Items.Clear();

        list.ForEach(i =>
        {
            item[0] = i.CheatmealId.ToString();
            item[1] = i.CheatmealName;
            item[2] = i.CheatCalorieGain.ToString();

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
    private void updateChangesToCheatmealModel()
    {
        CheatmealModel udpatedCheatmealModel = new CheatmealModel();
        CheatmealModel cheatmealModel = cheatmealService.getCheatmealById(int.Parse(hiddenCheatmealIDText.Text));

        udpatedCheatmealModel.CheatmealId = int.Parse(hiddenCheatmealIDText.Text);
        udpatedCheatmealModel.CheatmealName = cheatmealNameText.Text;
        udpatedCheatmealModel.CheatCalorieGain = caloriesGainRateNumeric.Value;

        if (cheatmealModel.Equals(udpatedCheatmealModel))
        {
            MessageBox.Show("No changes to update");
            return;
        }
        else
        {
            bool result = cheatmealService.updateCheatmeal(udpatedCheatmealModel);
            if (result)
            {
                MessageBox.Show($" {cheatmealModel.CheatmealId} updated successfully");
                editButtonClicked = false;
            }
            else
            {
                MessageBox.Show("Something went wrong, try later");
            }
        }

    }


    //Buttons 
    private void saveCheatmealButton_Click(object sender, EventArgs e)
    {
        //add edit function here
        if (editButtonClicked)
        {
            updateChangesToCheatmealModel();
            clearForm();
            setupListView();
            return;
        }

        if (cheatmealNameText.Text.Length < 3)
        {
            MessageBox.Show("Pls enter valid cheat meal name");
            cheatmealNameText.Focus();
            return;
        }

        CheatmealModel cheatmealModel = new CheatmealModel();

        cheatmealModel.CheatmealId = TemporaryDataStore.CheatmealIDCounter + 1;
        cheatmealModel.CheatmealName = cheatmealNameText.Text;
        cheatmealModel.CheatCalorieGain = caloriesGainRateNumeric.Value;


        if (cheatmealService.createCheatmeal(cheatmealModel))
        {
            MessageBox.Show($"Workout {cheatmealModel.CheatmealName} saved successfully");
            TemporaryDataStore.CheatmealIDCounter += 1;
            setupListView();
            clearForm();
            return;
        }
    }

    private void deleteCheatmealButton_Click(object sender, EventArgs e)
    {
        int cheatmealID;

        if (cheatmealListView.SelectedItems.Count > 0)
        {
            cheatmealID = int.Parse(cheatmealListView.SelectedItems[0].Text);

            if (cheatmealService.deleteCheatmeal(cheatmealID))
            {
                MessageBox.Show($"Cheatmeal ID {cheatmealID} is deleted successfully");
                setupListView();
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

    private void editCheatmealButton_Click(object sender, EventArgs e)
    {
        int cheatmealID;

        if (cheatmealListView.SelectedItems.Count > 0)
        {
            cheatmealID = int.Parse(cheatmealListView.SelectedItems[0].Text);
            CheatmealModel cheatmealModel = cheatmealService.getCheatmealById(cheatmealID);
            if (cheatmealModel != null)
            {
                hiddenCheatmealIDText.Text = cheatmealID.ToString();
                cheatmealNameText.Text = cheatmealModel.CheatmealName;
                caloriesGainRateNumeric.Value = cheatmealModel.CheatCalorieGain;
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
