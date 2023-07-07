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

public partial class ProfileUserControlForm : UserControl
{

    public UserService userService = new UserService();
    public ProfileUserControlForm()
    {
        InitializeComponent();
        setUserDataAtLoad();
    }

    private void setUserDataAtLoad()
    {
        fullNameText.Text = Program.getLoggedInUser().Name;
        emailText.Text = Program.getLoggedInUser().Email;

        UserProfileModel model = userService.getUserByEmail(Program.getLoggedInUser().Email);

        if (model.Gender == FlashFitClassLibrary.Enumz.GenderTypeEnum.MALE)
        {
            maleRadioButton.Checked = true;

        }
        else
        {
            femaleRadioButton.Checked = true;

        }
        heightNumeric.Value = model.HeightInCentiMeter;
        wieghtNumeric.Value = model.WeightInKiloGrams;
    }

    private void userProfileSaveButton_Click(object sender, EventArgs e)
    {

        UserProfileModel model = new UserProfileModel();
        //UserProfileModel user = TemporaryDataStore.userProfiles.Find(x => x.Email == emailText.Text);

        model.Name = fullNameText.Text;
        model.Email = emailText.Text;
        model.Gender = maleRadioButton.Checked ? FlashFitClassLibrary.Enumz.GenderTypeEnum.MALE : FlashFitClassLibrary.Enumz.GenderTypeEnum.FEMALE;
        model.WeightInKiloGrams = wieghtNumeric.Value;
        model.HeightInCentiMeter = heightNumeric.Value;

        //TODO: check if the user is found or not if found update else add
        Console.WriteLine(TemporaryDataStore.userProfiles);
        Console.WriteLine();

        userService = new UserService();
        UserProfileModel updatedValue = userService.updateUser(model);
        if (updatedValue == null)
        {
            MessageBox.Show("User not found to update");
        }
        else
        {
            MessageBox.Show($"User {model.Name} updated successfully");
        }

        //loadListView();



    }

    //private void loadListView()
    //{
    //    HashSet<UserProfileModel> userList = TemporaryDataStore.userProfiles;
    //    string[] item = new string[3];
    //    ListViewItem listItem;
    //    listView1.Items.Clear();

    //    foreach (var i in userList)
    //    {

    //        item[0] = i.Name;
    //        item[1] = i.Email;
    //        item[2] = i.WeightInKiloGrams.ToString();


    //        listItem = new ListViewItem(item);
    //        listView1.Items.Add(listItem);
    //    }
    //}

    private void loadFormDataFromLoggedInuser()
    {
        //loadListView();
        setUserDataAtLoad();
    }
}
