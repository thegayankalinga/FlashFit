﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FlashFitClassLibrary.Models;

namespace FlashFitWinFormUI;

public partial class MainForm : Form
{

    //This code makes the form UI round in 4 corners 
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );


    public MainForm()
    {
        InitializeComponent();
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        //set the initial selection to dashbord button in the navigation panel.
        moveHighlighter(dashboardButton, navigationPanel);
        UserProfileModel loggedInUser = Program.getLoggedInUser();
        userNameLabel.Text = loggedInUser.Name;
        userEmailLabel.Text = loggedInUser.Email;

        dashboardButton.Select();
        dashboardCustomControl1.BringToFront();
    }

    private void recordWorkoutButton_Click(object sender, EventArgs e)
    {
        //change the panel focus to this button
        moveHighlighter(recordWorkoutButton, navigationPanel);
        workoutUserControlForm1.BringToFront();

    }

    private void reportButton_Click(object sender, EventArgs e)
    {
        //change the panel focus to this button
        moveHighlighter(reportButton, navigationPanel);
        reportUserControlForm1.BringToFront();

    }

    private void recordCheatmealButton_Click(object sender, EventArgs e)
    {
        //change the panel focus to this button
        moveHighlighter(recordCheatmealButton, navigationPanel);
        cheatmealUserControlForm1.BringToFront();
    }

    private void predictionButton_Click(object sender, EventArgs e)
    {
        //change the panel focus to this button
        moveHighlighter(predictionButton, navigationPanel);
        predictionUserControlForm1.BringToFront();
    }

    private void dashboardButton_Click(object sender, EventArgs e)
    {
        //change the panel focus to this button
        moveHighlighter(dashboardButton, navigationPanel);
        dashboardCustomControl1.BringToFront();
    }

    public void moveHighlighter(Button btn, Panel panel)
    {
        panel.Height = btn.Height;
        panel.Top = btn.Top;
        panel.Left = btn.Left;
        btn.BackColor = Color.FromArgb(46, 51, 73);


    }

    private void profileButton_Click(object sender, EventArgs e)
    {
        //change the panel focus to this button
        moveHighlighter(profileButton, navigationPanel);
        MessageBox.Show("Checkback later");
        //profileUserControlForm1.BringToFront();

        mainFormPanelHeaderLabel.Text = "User Profile";
    }


    /// <summary>
    /// When leaving set the original color back for all buttons. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void dashboardButton_Leave(object sender, EventArgs e)
    {
        //upon leaving set the background color back to original color
        dashboardButton.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void recordWorkoutButton_Leave(object sender, EventArgs e)
    {
        //upon leaving set the background color back to original color
        recordWorkoutButton.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void recordCheatmealButton_Leave(object sender, EventArgs e)
    {
        //upon leaving set the background color back to original color
        recordCheatmealButton.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void reportButton_Leave(object sender, EventArgs e)
    {
        //upon leaving set the background color back to original color
        reportButton.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void predictionButton_Leave(object sender, EventArgs e)
    {
        //upon leaving set the background color back to original color
        predictionButton.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void profileButton_Leave(object sender, EventArgs e)
    {
        //upon leaving set the background color back to original color
        profileButton.BackColor = Color.FromArgb(24, 30, 54);
    }

    private void closeMainFormButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void logoutButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
