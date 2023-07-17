namespace FlashFitWinFormUI
{
    partial class ProfileUserControlForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userProfileSaveButton = new Button();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            fullNameText = new TextBox();
            emailText = new TextBox();
            wieghtNumeric = new NumericUpDown();
            heightNumeric = new NumericUpDown();
            fullNameLabel = new Label();
            emailLabel = new Label();
            genderGroupBox = new GroupBox();
            weightLabel = new Label();
            heightLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)wieghtNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).BeginInit();
            genderGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // userProfileSaveButton
            // 
            userProfileSaveButton.BackColor = Color.FromArgb(46, 51, 73);
            userProfileSaveButton.FlatStyle = FlatStyle.Flat;
            userProfileSaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userProfileSaveButton.ForeColor = SystemColors.ButtonHighlight;
            userProfileSaveButton.Location = new Point(167, 447);
            userProfileSaveButton.Margin = new Padding(4);
            userProfileSaveButton.Name = "userProfileSaveButton";
            userProfileSaveButton.Size = new Size(154, 48);
            userProfileSaveButton.TabIndex = 1;
            userProfileSaveButton.Text = "Update";
            userProfileSaveButton.UseVisualStyleBackColor = false;
            userProfileSaveButton.Click += userProfileSaveButton_Click;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(8, 31);
            maleRadioButton.Margin = new Padding(4);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(62, 25);
            maleRadioButton.TabIndex = 2;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(108, 31);
            femaleRadioButton.Margin = new Padding(4);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(78, 25);
            femaleRadioButton.TabIndex = 3;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // fullNameText
            // 
            fullNameText.Location = new Point(167, 45);
            fullNameText.Margin = new Padding(4);
            fullNameText.Name = "fullNameText";
            fullNameText.Size = new Size(358, 29);
            fullNameText.TabIndex = 4;
            // 
            // emailText
            // 
            emailText.Enabled = false;
            emailText.Location = new Point(167, 98);
            emailText.Margin = new Padding(4);
            emailText.Name = "emailText";
            emailText.Size = new Size(358, 29);
            emailText.TabIndex = 5;
            // 
            // wieghtNumeric
            // 
            wieghtNumeric.Location = new Point(167, 274);
            wieghtNumeric.Margin = new Padding(4);
            wieghtNumeric.Maximum = new decimal(new int[] { 700, 0, 0, 0 });
            wieghtNumeric.Name = "wieghtNumeric";
            wieghtNumeric.Size = new Size(154, 29);
            wieghtNumeric.TabIndex = 6;
            wieghtNumeric.TextAlign = HorizontalAlignment.Right;
            wieghtNumeric.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // heightNumeric
            // 
            heightNumeric.Location = new Point(167, 329);
            heightNumeric.Margin = new Padding(4);
            heightNumeric.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            heightNumeric.Name = "heightNumeric";
            heightNumeric.Size = new Size(154, 29);
            heightNumeric.TabIndex = 7;
            heightNumeric.TextAlign = HorizontalAlignment.Right;
            heightNumeric.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.ForeColor = SystemColors.ButtonFace;
            fullNameLabel.Location = new Point(40, 49);
            fullNameLabel.Margin = new Padding(4, 0, 4, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(81, 21);
            fullNameLabel.TabIndex = 8;
            fullNameLabel.Text = "Full Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = SystemColors.ButtonFace;
            emailLabel.Location = new Point(40, 104);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(48, 21);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email";
            // 
            // genderGroupBox
            // 
            genderGroupBox.Controls.Add(maleRadioButton);
            genderGroupBox.Controls.Add(femaleRadioButton);
            genderGroupBox.ForeColor = SystemColors.ButtonFace;
            genderGroupBox.Location = new Point(167, 155);
            genderGroupBox.Margin = new Padding(4);
            genderGroupBox.Name = "genderGroupBox";
            genderGroupBox.Padding = new Padding(4);
            genderGroupBox.Size = new Size(197, 90);
            genderGroupBox.TabIndex = 10;
            genderGroupBox.TabStop = false;
            genderGroupBox.Text = "Gender";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.ForeColor = SystemColors.ButtonFace;
            weightLabel.Location = new Point(40, 277);
            weightLabel.Margin = new Padding(4, 0, 4, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(92, 21);
            weightLabel.TabIndex = 9;
            weightLabel.Text = "Weight (KG)";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.ForeColor = SystemColors.ButtonFace;
            heightLabel.Location = new Point(40, 339);
            heightLabel.Margin = new Padding(4, 0, 4, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(94, 21);
            heightLabel.TabIndex = 9;
            heightLabel.Text = "Height (CM)";
            // 
            // ProfileUserControlForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(genderGroupBox);
            Controls.Add(heightLabel);
            Controls.Add(weightLabel);
            Controls.Add(emailLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(heightNumeric);
            Controls.Add(wieghtNumeric);
            Controls.Add(emailText);
            Controls.Add(fullNameText);
            Controls.Add(userProfileSaveButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ProfileUserControlForm";
            Size = new Size(970, 528);
            Load += ProfileUserControlForm_Load;
            ((System.ComponentModel.ISupportInitialize)wieghtNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).EndInit();
            genderGroupBox.ResumeLayout(false);
            genderGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button userProfileSaveButton;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private TextBox fullNameText;
        private TextBox emailText;
        private NumericUpDown wieghtNumeric;
        private NumericUpDown heightNumeric;
        private Label fullNameLabel;
        private Label emailLabel;
        private GroupBox genderGroupBox;
        private Label weightLabel;
        private Label heightLabel;
    }
}
