using FlashFitClassLibrary.Resources.User;
using FlashFitClassLibrary.Services;
using FlashFitWinFormUI.Services;
using System.Reflection.Metadata.Ecma335;

namespace FlashFitWinFormUI;


public partial class UserLoginForm : Form
{

    //This is not the correct way to do this 
    private static UserResource? user;
    private readonly UserService _userService;
    public UserLoginForm()
    {
        InitializeComponent();
        _userService = new UserService();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Form registerForm = new UserRegistrationForm();
        this.Hide();
        registerForm.ShowDialog();
    }

    private async void loginButton_ClickAsync(object sender, EventArgs e)
    {

        if (ValidatorService.ValidateTextField(emailAddressTextbox) == false)
        {
            MessageBox.Show("Email field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            emailAddressTextbox.Focus();
            return;
        }


        string? email = emailAddressTextbox.Text;

        if (ValidatorService.ValidateTextField(passwordTextbox) == false)
        {
            MessageBox.Show("Password field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            passwordTextbox.Focus();
            return;
        }

        string? password = passwordTextbox.Text;

        user = await _userService.ValidateUser(email, password);

        if (user != null)
        {
            Program.loggedInUser = user;
            MainForm homeScreen = new MainForm();
            //MessageBox.Show("Done");

            this.Hide();
            homeScreen.ShowDialog();

        }
        else
        {
            MessageBox.Show($"Please login or register to continue");
        }


    }


}
