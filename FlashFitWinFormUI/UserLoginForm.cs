using FlashFitClassLibrary.Exceptions;
using FlashFitClassLibrary.Resources.User;
using FlashFitUIClassLibrary.HttpApiProcessor;
using FlashFitUserManagementService;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashFitWinFormUI;


public partial class UserLoginForm : Form
{

    private readonly string _host = Environment.GetEnvironmentVariable("REMOTEAPIGATEWYHOST");
    private readonly string _port = Environment.GetEnvironmentVariable("REMOTEAPIGATEWAYPORT");
    //This is not the correct way to do this 
    private static UserResource? loggedInUser;
    private static bool validUser = false;
    public UserLoginForm()
    {
        InitializeComponent();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Form registerForm = new UserRegistrationForm();
        this.Hide();
        registerForm.ShowDialog();
    }

    private async void loginButton_ClickAsync(object sender, EventArgs e)
    {
        string? email = emailAddressTextbox.Text;
        string? password = passwordTextbox.Text;

        if(email != null && password != null )
        {
            await ValidateUser(email, password);
            if(validUser && loggedInUser != null)
            {
                Program.loggedInUser = loggedInUser;
                Form homeScreen = new MainForm(loggedInUser);
                this.Hide();
                homeScreen.ShowDialog();

            }
            else
            {
                MessageBox.Show($"Please login or register to continue {validUser}");
            }

            
        }
        else if(email == null)
        {
            MessageBox.Show("Pls recheck your email");
            emailAddressTextbox.Focus();
        }else if(password == null)
        {
            MessageBox.Show("Password cannot be empty");
            passwordTextbox.Focus();
        }
        else
        {
            MessageBox.Show("Pls enter details to login");
        }
        
    }

    private async Task ValidateUser(string email, string password)
    {
        var data = RestService.For<IUserDataProcessor>($"https://{_host}:{_port}");
        LoginResource loginResource = new LoginResource(email, password);
        try
        {

            loggedInUser = await data.LoginUser(loginResource);
            validUser = true;
        }
        catch
        {
            validUser = false;
        }

    }
}
