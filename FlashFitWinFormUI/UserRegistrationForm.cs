using FlashFitClassLibrary.Enumz;
using FlashFitClassLibrary.Exceptions;
using FlashFitClassLibrary.Resources.User;
using FlashFitClassLibrary.Services;
using FlashFitWinFormUI.Services;

namespace FlashFitWinFormUI;

public partial class UserRegistrationForm : Form
{
    private readonly UserService _userService = new UserService();
    UserLoginForm loginForm = new UserLoginForm();
    public UserRegistrationForm()
    {
        InitializeComponent();
    }

    private void loginLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

        this.Hide();
        loginForm.Show();
        this.Close();

    }

    private async void registerButton_Click(object sender, EventArgs e)
    {
        ValidatorService.ValidateTextField(emailSignupTextbox);
        string email = emailSignupTextbox.Text;
        if (ValidatorService.IsValidEmail(email) == false)
        {
            MessageBox.Show("Invalid Email, please re-check");
            emailSignupTextbox.Focus();
        }

        ValidatorService.ValidateTextField(passwordSignupText);
        string password = passwordSignupText.Text;

        ValidatorService.ValidateTextField(nameSignupText);
        string name = nameSignupText.Text;

        DateTime birthdate = birthDateTimePicker.Value;
        GenderTypeEnum gender = maleRadioButton.Checked ? GenderTypeEnum.MALE : GenderTypeEnum.FEMALE;
        decimal weight = weightNumeric.Value;
        decimal height = heightNumeric.Value;

        RegisterResource registerUserData = new RegisterResource(email, password, name, gender.ToString(), birthdate, weight, height, 0, "NONE");

 

        try
        {
            UserResource userData = await _userService.createUser(registerUserData);

            if (userData != null)
            {
                MessageBox.Show("Successfully Added, click ok to Go to Login Screen", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }


        }
        catch (ExistinUserFoundException em)
        {
            MessageBox.Show($" Pls Login {em.Message}");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Something went wrong {ex.Message}");
        }

    }
}
