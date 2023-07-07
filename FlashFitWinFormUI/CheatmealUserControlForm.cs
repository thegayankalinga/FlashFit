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

namespace FlashFitWinFormUI
{
    public partial class CheatmealUserControlForm : UserControl
    {

        CheatmealService service = new CheatmealService();
        UserService userService = new UserService();
        CheatmealRecoredService cheatmealRecoredService = new CheatmealRecoredService();
        bool editButtonClicked = false;

        public CheatmealUserControlForm()
        {
            InitializeComponent();
            
            selectCheatmealComboBox.ResetText();
            selectCheatmealComboBox.Items.AddRange(generateComboBoxValues().ToArray());
            cheatmealDateTimePicker.Value = DateTime.Now;
        }

        private void setupListView()
        {
            List<CheatmealRecordModel> list = TemporaryDataStore.cheatmealRecords;
            string[] item = new string[5];
            ListViewItem listItem;
            cheatmealRecordListView.Items.Clear();

            foreach (var x in list)
            {
                item[0] = x.CheatmealRecordID.ToString();
                item[1] = x.Cheatmeal.CheatmealName;
                item[2] = x.CheatmealAddedDateTime.ToString();
                item[3] = x.Cheatmeal.CheatCalorieGain.ToString();
                item[4] = x.WeightAtMealRecordTime.ToString();

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
        private void updateChangestoCheatmealRecord()
        {
            CheatmealRecordModel updatedRecordModel = new CheatmealRecordModel();
            CheatmealModel cheatmealModel = new CheatmealModel();


            CheatmealRecordModel cheatmealRecordModel = cheatmealRecoredService.getCheatmealRecordById(int.Parse(hiddenCheatmealRecordIDText.Text));
            if (cheatmealRecordModel != null)
            {
                if (selectCheatmealComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Reselect the Workout");
                    selectCheatmealComboBox.Focus();
                    selectCheatmealComboBox.DroppedDown = true;
                    return;
                }

                int cheatmealID = int.Parse(selectCheatmealComboBox.SelectedItem.ToString().Substring(0, 1));
                cheatmealModel = service.getCheatmealById(cheatmealID);

                updatedRecordModel.CheatmealRecordID = int.Parse(hiddenCheatmealRecordIDText.Text);
                updatedRecordModel.Cheatmeal = cheatmealModel;
                updatedRecordModel.CheatmealAddedDateTime = cheatmealDateTimePicker.Value;
                updatedRecordModel.UserEmail = Program.getLoggedInUser().Email;
                updatedRecordModel.WeightAtMealRecordTime = weightAtCheatmealNumeric.Value;

                if (cheatmealRecordModel.Equals(updatedRecordModel))
                {
                    MessageBox.Show("No changes to update");
                    return;
                }
                else
                {
                    bool result = cheatmealRecoredService.updateCheatmealRecord(updatedRecordModel);
                    if (result)
                    {
                        MessageBox.Show($" Cheatmeal Record ID {cheatmealRecordModel.CheatmealRecordID} updated successfully");
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
                MessageBox.Show("Pls select the Cheatmeal");
                selectCheatmealComboBox.Focus();
                return;
            }

        }
        private List<string> generateComboBoxValues()
        {
            List<string> comboBoxLoadList = new List<string>();
            comboBoxLoadList.Add("0 - Select");

            TemporaryDataStore.cheatmealModels.ForEach(model =>
            {
                string combinedValue = $"{model.CheatmealId} - {model.CheatmealName}";
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

        private void CheatmealUserControlForm_Load(object sender, EventArgs e)
        {
            TemporaryDataStore.CheatmealRecordIdCounter = TemporaryDataStore.cheatmealRecords.Count + 1;
            setupListView();
            selectCheatmealComboBox.SelectedText = "0 - Select";
        }

        private void workoutRecordDeleteButton_Click(object sender, EventArgs e)
        {
            int cheatmealID;

            if (cheatmealRecordListView.SelectedItems.Count > 0)
            {
                cheatmealID = int.Parse(cheatmealRecordListView.SelectedItems[0].Text);
                if (cheatmealRecoredService.deleteCheatmealRecord(cheatmealID))
                {
                    MessageBox.Show($"Cheatmeal Record ID {cheatmealID} is deleted successfully");
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

        private void workoutRecordEditButton_Click(object sender, EventArgs e)
        {
            int cheatmealID;

            if (cheatmealRecordListView.SelectedItems.Count > 0)
            {
                cheatmealID = int.Parse(cheatmealRecordListView.SelectedItems[0].Text);
                CheatmealRecordModel model = cheatmealRecoredService.getCheatmealRecordById(cheatmealID);

                if (model != null)
                {
                    string combinedText = $"{model.Cheatmeal.CheatmealId} - {model.Cheatmeal.CheatmealName}";
                    hiddenCheatmealRecordIDText.Text = model.CheatmealRecordID.ToString();
                    selectCheatmealComboBox.ResetText();
                    selectCheatmealComboBox.SelectedText = combinedText;
                    cheatmealDateTimePicker.Value = model.CheatmealAddedDateTime;
                    weightAtCheatmealNumeric.Value = model.WeightAtMealRecordTime;
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

        private void saveCheatmealRecordButton_Click(object sender, EventArgs e)
        {
            if (editButtonClicked)
            {
                updateChangestoCheatmealRecord();
                setupListView();
                return;
            }

            CheatmealRecordModel cheatmealRecordModel = new CheatmealRecordModel();
            CheatmealModel cheatmealModel = new CheatmealModel();
            int cheatmealID;

            int selectedIndex = selectCheatmealComboBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                cheatmealID = int.Parse(selectCheatmealComboBox.SelectedItem.ToString().Substring(0, 1));
                cheatmealModel = service.getCheatmealById(cheatmealID);
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

                cheatmealRecordModel.CheatmealRecordID = TemporaryDataStore.CheatmealRecordIdCounter + 1;
                cheatmealRecordModel.Cheatmeal = cheatmealModel;
                cheatmealRecordModel.UserEmail = Program.getLoggedInUser().Email;
                cheatmealRecordModel.WeightAtMealRecordTime = weightAtCheatmealNumeric.Value;
                cheatmealRecordModel.CheatmealAddedDateTime = cheatmealDateTimePicker.Value;

                userService.updateUserWeight(cheatmealRecordModel.WeightAtMealRecordTime, cheatmealRecordModel.UserEmail);
                TemporaryDataStore.cheatmealRecords.Add(cheatmealRecordModel);
                MessageBox.Show($"Your workout recorded successfully");
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
    }
}
