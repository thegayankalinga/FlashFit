
using FlashFitClassLibrary.Enumz;
using FlashFitClassLibrary.Resources.User;
using FlashFitClassLibrary.Services;
using FlashFitWinFormUI.Services;

namespace FlashFitWinFormUI;

public partial class ProfileUserControlForm : UserControl
{

    readonly UserService _userService;
    public ProfileUserControlForm()
    {
        InitializeComponent();
        _userService = new UserService();

    }

    private async void userProfileSaveButton_Click(object sender, EventArgs e)
    {
        if(ValidatorService.ValidateTextField(fullNameText) == false)
        {
            MessageBox.Show("Name cannot be empty");
        }
        string name = fullNameText.Text;

        string email = emailText.Text;
        DateTime brithDate = birthDatePicker.Value;
        GenderTypeEnum gender = maleRadioButton.Checked ? GenderTypeEnum.MALE : GenderTypeEnum.FEMALE;

        if(wieghtNumeric.Value <= 0)
        {
            MessageBox.Show("Cannot be 0");
        }

        decimal weight = wieghtNumeric.Value;

        if(heightNumeric.Value <= 0)
        {
            MessageBox.Show("Cannot be 0 or less");
        }
        decimal height = heightNumeric.Value;



        //(HealthStatusEnum)Enum.Parse(typeof(HealthStatusEnum), user.HeathStatus)

        UserResource modelToBeUpdated = new(email, name, gender.ToString(), brithDate, weight, height, 0, "NONE");


        UserResource? updatedValue = await _userService.updateUser(modelToBeUpdated);

        if (updatedValue == null)
        {
            MessageBox.Show("Not updated, Something went wrong");
        }
        else
        {
            
            plcToBmiLable.Text = updatedValue.BodyMassIndex.ToString();
            plcHealthStatusLabel.Text = updatedValue.HeathStatus.ToString();
            plcToBmiLable.Text = updatedValue.BodyMassIndex.ToString();
            MessageBox.Show($"User {updatedValue.Name} updated successfully");
        }
    }

    private void ProfileUserControlForm_Load(object sender, EventArgs e)
    {
        setUserDataAtLoad();
    }

    private void setUserDataAtLoad()
    {
        fullNameText.Text = Program.getLoggedInUser().Name;
        emailText.Text = Program.getLoggedInUser().Email;

        GenderTypeEnum gender;

        if (Program.getLoggedInUser().Gender.Equals("MALE"))
        {
            gender = GenderTypeEnum.MALE;
        }
        else
        {
            gender = GenderTypeEnum.FEMALE;
        }

        if (gender == FlashFitClassLibrary.Enumz.GenderTypeEnum.MALE)
        {
            maleRadioButton.Checked = true;

        }
        else
        {
            femaleRadioButton.Checked = true;

        }
        heightNumeric.Value = Program.getLoggedInUser().HeightInCentiMeter;
        wieghtNumeric.Value = Program.getLoggedInUser().WeightInKiloGrams;
        birthDatePicker.Value = Program.getLoggedInUser().BirthDate;
        plcHealthStatusLabel.Text = Program.getLoggedInUser().HeathStatus.ToString();
        plcToBmiLable.Text = Program.getLoggedInUser().BodyMassIndex.ToString();

    }
}
