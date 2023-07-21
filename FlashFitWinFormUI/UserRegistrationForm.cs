using FlashFitClassLibrary.Enumz;
using FlashFitClassLibrary.Resources.User;
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
        string email = emailSignupTextbox.Text;
        string password = passwordSignupText.Text;
        string name = nameSignupText.Text;
        DateTime birthdate = birthDateTimePicker.Value;
        GenderTypeEnum gender = maleRadioButton.Checked ? GenderTypeEnum.MALE : GenderTypeEnum.FEMALE;
        decimal weight = weightNumeric.Value;
        decimal height = heightNumeric.Value;

        RegisterResource registerUserData = new RegisterResource(email, password, name, gender, birthdate, weight, height, 0, 0);

        try
        {
            UserResource userData = await _userService.createUser(registerUserData);
            if(userData != null)
            {
                this.Hide();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Something went wrong, Try again later");
            }

        }catch (Exception ex)
        {
            MessageBox.Show($"Something went wrong {ex.Message}");
        }

    }
}
