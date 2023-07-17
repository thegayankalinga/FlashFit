
using FlashFitClassLibrary.InitialData;
using FlashFitClassLibrary.Models;
using FlashFitClassLibrary.Services;


namespace FlashFitWinFormUI;

public partial class ProfileUserControlForm : UserControl
{

    UserService userService = new UserService();
    public ProfileUserControlForm()
    {
        InitializeComponent();

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

    private void ProfileUserControlForm_Load(object sender, EventArgs e)
    {
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
}
