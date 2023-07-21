namespace FlashFitWinFormUI
{
    partial class UserRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NumericUpDown heightNumeric;
            signupHeaderLabel = new Label();
            hasAccountLabel = new Label();
            loginLinkedLabel = new LinkLabel();
            emailSignupTextbox = new TextBox();
            emailSignupLabel = new Label();
            passwordSignupLabel = new Label();
            passwordSignupText = new TextBox();
            nameSignupLabel = new Label();
            nameSignupText = new TextBox();
            genderGroupBox = new GroupBox();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            birthDateTimePicker = new DateTimePicker();
            birthDatePickerLabel = new Label();
            weightNumeric = new NumericUpDown();
            heightLabel = new Label();
            weighLabel = new Label();
            groupBox1 = new GroupBox();
            registerButton = new Button();
            heightNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).BeginInit();
            genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightNumeric).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // heightNumeric
            // 
            heightNumeric.Location = new Point(350, 378);
            heightNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            heightNumeric.Name = "heightNumeric";
            heightNumeric.Size = new Size(120, 29);
            heightNumeric.TabIndex = 11;
            heightNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // signupHeaderLabel
            // 
            signupHeaderLabel.AutoSize = true;
            signupHeaderLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            signupHeaderLabel.ForeColor = SystemColors.ButtonHighlight;
            signupHeaderLabel.Location = new Point(28, -5);
            signupHeaderLabel.Name = "signupHeaderLabel";
            signupHeaderLabel.Size = new Size(91, 30);
            signupHeaderLabel.TabIndex = 2;
            signupHeaderLabel.Text = "Sign Up";
            // 
            // hasAccountLabel
            // 
            hasAccountLabel.AutoSize = true;
            hasAccountLabel.ForeColor = SystemColors.ActiveCaption;
            hasAccountLabel.Location = new Point(40, 80);
            hasAccountLabel.Name = "hasAccountLabel";
            hasAccountLabel.Size = new Size(190, 21);
            hasAccountLabel.TabIndex = 3;
            hasAccountLabel.Text = "Already have an account ?";
            // 
            // loginLinkedLabel
            // 
            loginLinkedLabel.ActiveLinkColor = Color.DarkRed;
            loginLinkedLabel.AutoSize = true;
            loginLinkedLabel.BorderStyle = BorderStyle.FixedSingle;
            loginLinkedLabel.LinkColor = Color.IndianRed;
            loginLinkedLabel.Location = new Point(236, 80);
            loginLinkedLabel.Name = "loginLinkedLabel";
            loginLinkedLabel.Size = new Size(51, 23);
            loginLinkedLabel.TabIndex = 4;
            loginLinkedLabel.TabStop = true;
            loginLinkedLabel.Text = "Login";
            loginLinkedLabel.LinkClicked += loginLinkedLabel_LinkClicked;
            // 
            // emailSignupTextbox
            // 
            emailSignupTextbox.Location = new Point(40, 160);
            emailSignupTextbox.Name = "emailSignupTextbox";
            emailSignupTextbox.Size = new Size(274, 29);
            emailSignupTextbox.TabIndex = 7;
            // 
            // emailSignupLabel
            // 
            emailSignupLabel.AutoSize = true;
            emailSignupLabel.ForeColor = SystemColors.ControlLightLight;
            emailSignupLabel.Location = new Point(40, 126);
            emailSignupLabel.Name = "emailSignupLabel";
            emailSignupLabel.Size = new Size(108, 21);
            emailSignupLabel.TabIndex = 6;
            emailSignupLabel.Text = "Email Address";
            // 
            // passwordSignupLabel
            // 
            passwordSignupLabel.AutoSize = true;
            passwordSignupLabel.ForeColor = SystemColors.ControlLightLight;
            passwordSignupLabel.Location = new Point(40, 206);
            passwordSignupLabel.Name = "passwordSignupLabel";
            passwordSignupLabel.Size = new Size(76, 21);
            passwordSignupLabel.TabIndex = 6;
            passwordSignupLabel.Text = "Password";
            // 
            // passwordSignupText
            // 
            passwordSignupText.Location = new Point(40, 240);
            passwordSignupText.Name = "passwordSignupText";
            passwordSignupText.PasswordChar = '#';
            passwordSignupText.Size = new Size(274, 29);
            passwordSignupText.TabIndex = 7;
            // 
            // nameSignupLabel
            // 
            nameSignupLabel.AutoSize = true;
            nameSignupLabel.ForeColor = SystemColors.ControlLightLight;
            nameSignupLabel.Location = new Point(40, 291);
            nameSignupLabel.Name = "nameSignupLabel";
            nameSignupLabel.Size = new Size(52, 21);
            nameSignupLabel.TabIndex = 6;
            nameSignupLabel.Text = "Name";
            // 
            // nameSignupText
            // 
            nameSignupText.Location = new Point(40, 325);
            nameSignupText.Name = "nameSignupText";
            nameSignupText.PasswordChar = '#';
            nameSignupText.Size = new Size(274, 29);
            nameSignupText.TabIndex = 7;
            // 
            // genderGroupBox
            // 
            genderGroupBox.Controls.Add(maleRadioButton);
            genderGroupBox.Controls.Add(femaleRadioButton);
            genderGroupBox.ForeColor = Color.Honeydew;
            genderGroupBox.Location = new Point(346, 127);
            genderGroupBox.Name = "genderGroupBox";
            genderGroupBox.Size = new Size(183, 100);
            genderGroupBox.TabIndex = 8;
            genderGroupBox.TabStop = false;
            genderGroupBox.Text = "Gender Selection";
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(16, 59);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(62, 25);
            maleRadioButton.TabIndex = 0;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(16, 28);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(78, 25);
            femaleRadioButton.TabIndex = 0;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Location = new Point(40, 411);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(274, 29);
            birthDateTimePicker.TabIndex = 10;
            // 
            // birthDatePickerLabel
            // 
            birthDatePickerLabel.AutoSize = true;
            birthDatePickerLabel.ForeColor = SystemColors.ControlLightLight;
            birthDatePickerLabel.Location = new Point(40, 377);
            birthDatePickerLabel.Name = "birthDatePickerLabel";
            birthDatePickerLabel.Size = new Size(73, 21);
            birthDatePickerLabel.TabIndex = 6;
            birthDatePickerLabel.Text = "Birthdate";
            // 
            // weightNumeric
            // 
            weightNumeric.Location = new Point(348, 292);
            weightNumeric.Maximum = new decimal(new int[] { 1500, 0, 0, 0 });
            weightNumeric.Name = "weightNumeric";
            weightNumeric.Size = new Size(120, 29);
            weightNumeric.TabIndex = 11;
            weightNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.ForeColor = SystemColors.ControlLightLight;
            heightLabel.Location = new Point(348, 344);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(94, 21);
            heightLabel.TabIndex = 6;
            heightLabel.Text = "Height (Cm)";
            // 
            // weighLabel
            // 
            weighLabel.AutoSize = true;
            weighLabel.ForeColor = SystemColors.ControlLightLight;
            weighLabel.Location = new Point(346, 258);
            weighLabel.Name = "weighLabel";
            weighLabel.Size = new Size(92, 21);
            weighLabel.TabIndex = 6;
            weighLabel.Text = "Weight (KG)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(registerButton);
            groupBox1.Controls.Add(genderGroupBox);
            groupBox1.Controls.Add(weightNumeric);
            groupBox1.Controls.Add(heightNumeric);
            groupBox1.Controls.Add(signupHeaderLabel);
            groupBox1.Controls.Add(weighLabel);
            groupBox1.Controls.Add(heightLabel);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.AliceBlue;
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(546, 589);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // registerButton
            // 
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = SystemColors.ButtonHighlight;
            registerButton.Location = new Point(28, 509);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(501, 35);
            registerButton.TabIndex = 13;
            registerButton.Text = "Sign Up";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // UserRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(575, 659);
            Controls.Add(birthDateTimePicker);
            Controls.Add(nameSignupText);
            Controls.Add(birthDatePickerLabel);
            Controls.Add(nameSignupLabel);
            Controls.Add(passwordSignupText);
            Controls.Add(passwordSignupLabel);
            Controls.Add(emailSignupTextbox);
            Controls.Add(emailSignupLabel);
            Controls.Add(loginLinkedLabel);
            Controls.Add(hasAccountLabel);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "UserRegistrationForm";
            Text = "UserRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)heightNumeric).EndInit();
            genderGroupBox.ResumeLayout(false);
            genderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightNumeric).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signupHeaderLabel;
        private Label hasAccountLabel;
        private LinkLabel loginLinkedLabel;
        private TextBox emailSignupTextbox;
        private Label emailSignupLabel;
        private Label passwordSignupLabel;
        private TextBox passwordSignupText;
        private Label nameSignupLabel;
        private TextBox nameSignupText;
        private GroupBox genderGroupBox;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private DateTimePicker birthDateTimePicker;
        private Label birthDatePickerLabel;
        private NumericUpDown weightNumeric;
        private Label heightLabel;
        private NumericUpDown heightNumeric;
        private Label weighLabel;
        private GroupBox groupBox1;
        private Button registerButton;
    }
}