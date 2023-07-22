namespace FlashFitWinFormUI
{
    partial class UserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            loginHeaderLabel = new Label();
            noAccountLabel = new Label();
            signeUpLinkedLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            emailLabel = new Label();
            emailAddressTextbox = new TextBox();
            passwordLabel = new Label();
            passwordTextbox = new TextBox();
            loginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginHeaderLabel
            // 
            loginHeaderLabel.AutoSize = true;
            loginHeaderLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginHeaderLabel.ForeColor = SystemColors.ButtonHighlight;
            loginHeaderLabel.Location = new Point(49, 37);
            loginHeaderLabel.Name = "loginHeaderLabel";
            loginHeaderLabel.Size = new Size(69, 30);
            loginHeaderLabel.TabIndex = 1;
            loginHeaderLabel.Text = "Login";
            // 
            // noAccountLabel
            // 
            noAccountLabel.AutoSize = true;
            noAccountLabel.ForeColor = SystemColors.ActiveCaption;
            noAccountLabel.Location = new Point(49, 84);
            noAccountLabel.Name = "noAccountLabel";
            noAccountLabel.Size = new Size(199, 21);
            noAccountLabel.TabIndex = 2;
            noAccountLabel.Text = "Does not have an account ?";
            // 
            // signeUpLinkedLabel
            // 
            signeUpLinkedLabel.ActiveLinkColor = Color.DarkRed;
            signeUpLinkedLabel.AutoSize = true;
            signeUpLinkedLabel.LinkColor = Color.IndianRed;
            signeUpLinkedLabel.Location = new Point(244, 84);
            signeUpLinkedLabel.Name = "signeUpLinkedLabel";
            signeUpLinkedLabel.Size = new Size(65, 21);
            signeUpLinkedLabel.TabIndex = 3;
            signeUpLinkedLabel.TabStop = true;
            signeUpLinkedLabel.Text = "Sign Up";
            signeUpLinkedLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.Stinger_Fit_1;
            pictureBox1.InitialImage = Properties.Resources.Stinger_Fit_1;
            pictureBox1.Location = new Point(383, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = SystemColors.ControlLightLight;
            emailLabel.Location = new Point(51, 141);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(108, 21);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email Address";
            // 
            // emailAddressTextbox
            // 
            emailAddressTextbox.Location = new Point(51, 175);
            emailAddressTextbox.Name = "emailAddressTextbox";
            emailAddressTextbox.Size = new Size(258, 29);
            emailAddressTextbox.TabIndex = 1;
            emailAddressTextbox.Text = "bg15407@gmail.com";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = SystemColors.ControlLightLight;
            passwordLabel.Location = new Point(51, 231);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 21);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            passwordLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(51, 265);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(258, 29);
            passwordTextbox.TabIndex = 2;
            passwordTextbox.Text = "test";
            // 
            // loginButton
            // 
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(49, 357);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(260, 35);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_ClickAsync;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(773, 459);
            Controls.Add(loginButton);
            Controls.Add(passwordTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(emailAddressTextbox);
            Controls.Add(emailLabel);
            Controls.Add(signeUpLinkedLabel);
            Controls.Add(noAccountLabel);
            Controls.Add(loginHeaderLabel);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "UserLoginForm";
            Text = "UserLoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label loginHeaderLabel;
        private Label noAccountLabel;
        private LinkLabel signeUpLinkedLabel;
        private PictureBox pictureBox1;
        private Label emailLabel;
        private TextBox emailAddressTextbox;
        private Label passwordLabel;
        private TextBox passwordTextbox;
        private Button loginButton;
    }
}