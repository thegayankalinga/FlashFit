
using FlashFitClassLibrary.Enumz;
using FlashFitClassLibrary.InitialData;
using FlashFitClassLibrary.Models;
using FlashFitClassLibrary.Resources.User;
using FlashFitClassLibrary.Services;


namespace FlashFitWinFormUI;

public partial class ProfileUserControlForm : UserControl
{

    readonly UserService _userService = new UserService();
    public ProfileUserControlForm()
    {
        InitializeComponent();

    }

    private async void userProfileSaveButton_Click(object sender, EventArgs e)
    {


        //UserProfileModel user = TemporaryDataStore.userProfiles.Find(x => x.Email == emailText.Text);

        string name = fullNameText.Text;
        string email = emailText.Text;
        DateTime brithDate = birthDatePicker.Value;
        GenderTypeEnum gender = maleRadioButton.Checked ? GenderTypeEnum.MALE : GenderTypeEnum.FEMALE;
        decimal weight = wieghtNumeric.Value;
        decimal height = heightNumeric.Value;
        decimal bmi = 0; //TODO: Update the BMI
        HealthStatusEnum healthStatus = HealthStatusEnum.None; //TODO: Update the Health Status

        UserResource modelToBeUpdated = new(email, name, gender, brithDate, weight, height, bmi, healthStatus);


        UserResource updatedValue = await _userService.updateUser(modelToBeUpdated);
        if (updatedValue == null)
        {
            MessageBox.Show("User not found to update");
        }
        else
        {
            MessageBox.Show($"User {modelToBeUpdated.Name} updated successfully");
        }

        //loadListView();



    }

    private void ProfileUserControlForm_Load(object sender, EventArgs e)
    {
        setUserDataAtLoad();
    }

    private async void setUserDataAtLoad()
    {
        fullNameText.Text = Program.getLoggedInUser().Name;
        emailText.Text = Program.getLoggedInUser().Email;

        UserResource model = await _userService.getUserByEmail(Program.getLoggedInUser().Email);

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
        birthDatePicker.Value = model.BirthDate;
        plcHealthStatusLabel.Text = model.HeathStatus.ToString();
        plcToBmiLable.Text = model.BodyMassIndex.ToString();

    }
}
