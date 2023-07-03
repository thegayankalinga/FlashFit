namespace FlashFitWinFormUI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            logoutButton = new Button();
            profileButton = new Button();
            predictionButton = new Button();
            reportButton = new Button();
            recordCheatmealButton = new Button();
            recordWorkoutButton = new Button();
            dashboardButton = new Button();
            panel2 = new Panel();
            userNameLabel = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            navigationPanel = new Panel();
            dashboardCustomControl1 = new DashboardCustomControl();
            panel3 = new Panel();
            closeMainFormButton = new Button();
            workoutUserControlForm1 = new WorkoutUserControlForm();
            cheatmealUserControlForm1 = new CheatmealUserControlForm();
            reportUserControlForm1 = new ReportUserControlForm();
            predictionUserControlForm1 = new PredictionUserControlForm();
            profileUserControlForm1 = new ProfileUserControlForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(profileButton);
            panel1.Controls.Add(predictionButton);
            panel1.Controls.Add(reportButton);
            panel1.Controls.Add(recordCheatmealButton);
            panel1.Controls.Add(recordWorkoutButton);
            panel1.Controls.Add(dashboardButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Dock = DockStyle.Bottom;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.FromArgb(0, 126, 249);
            logoutButton.Image = Properties.Resources.log_out;
            logoutButton.ImageAlign = ContentAlignment.MiddleRight;
            logoutButton.Location = new Point(0, 535);
            logoutButton.Margin = new Padding(10, 3, 10, 3);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(10, 0, 10, 0);
            logoutButton.Size = new Size(186, 42);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.TextAlign = ContentAlignment.MiddleLeft;
            logoutButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // profileButton
            // 
            profileButton.Dock = DockStyle.Top;
            profileButton.FlatAppearance.BorderSize = 0;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            profileButton.ForeColor = Color.FromArgb(0, 126, 249);
            profileButton.Image = Properties.Resources.broken_heart;
            profileButton.ImageAlign = ContentAlignment.MiddleRight;
            profileButton.Location = new Point(0, 354);
            profileButton.Margin = new Padding(10, 3, 10, 3);
            profileButton.Name = "profileButton";
            profileButton.Padding = new Padding(10, 0, 10, 0);
            profileButton.Size = new Size(186, 42);
            profileButton.TabIndex = 1;
            profileButton.Text = "Profile";
            profileButton.TextAlign = ContentAlignment.MiddleLeft;
            profileButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
            profileButton.Leave += profileButton_Leave;
            // 
            // predictionButton
            // 
            predictionButton.Dock = DockStyle.Top;
            predictionButton.FlatAppearance.BorderSize = 0;
            predictionButton.FlatStyle = FlatStyle.Flat;
            predictionButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            predictionButton.ForeColor = Color.FromArgb(0, 126, 249);
            predictionButton.Image = Properties.Resources.light_bulb;
            predictionButton.ImageAlign = ContentAlignment.MiddleRight;
            predictionButton.Location = new Point(0, 312);
            predictionButton.Margin = new Padding(10, 3, 10, 3);
            predictionButton.Name = "predictionButton";
            predictionButton.Padding = new Padding(10, 0, 10, 0);
            predictionButton.Size = new Size(186, 42);
            predictionButton.TabIndex = 1;
            predictionButton.Text = "Prediction";
            predictionButton.TextAlign = ContentAlignment.MiddleLeft;
            predictionButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            predictionButton.UseVisualStyleBackColor = true;
            predictionButton.Click += predictionButton_Click;
            predictionButton.Leave += predictionButton_Leave;
            // 
            // reportButton
            // 
            reportButton.Dock = DockStyle.Top;
            reportButton.FlatAppearance.BorderSize = 0;
            reportButton.FlatStyle = FlatStyle.Flat;
            reportButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reportButton.ForeColor = Color.FromArgb(0, 126, 249);
            reportButton.Image = Properties.Resources.left_align;
            reportButton.ImageAlign = ContentAlignment.MiddleRight;
            reportButton.Location = new Point(0, 270);
            reportButton.Margin = new Padding(10, 3, 10, 3);
            reportButton.Name = "reportButton";
            reportButton.Padding = new Padding(10, 0, 10, 0);
            reportButton.Size = new Size(186, 42);
            reportButton.TabIndex = 1;
            reportButton.Text = "Report";
            reportButton.TextAlign = ContentAlignment.MiddleLeft;
            reportButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            reportButton.UseVisualStyleBackColor = true;
            reportButton.Click += reportButton_Click;
            reportButton.Leave += reportButton_Leave;
            // 
            // recordCheatmealButton
            // 
            recordCheatmealButton.Dock = DockStyle.Top;
            recordCheatmealButton.FlatAppearance.BorderSize = 0;
            recordCheatmealButton.FlatStyle = FlatStyle.Flat;
            recordCheatmealButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            recordCheatmealButton.ForeColor = Color.FromArgb(0, 126, 249);
            recordCheatmealButton.Image = Properties.Resources.store;
            recordCheatmealButton.ImageAlign = ContentAlignment.MiddleRight;
            recordCheatmealButton.Location = new Point(0, 228);
            recordCheatmealButton.Margin = new Padding(10, 3, 10, 3);
            recordCheatmealButton.Name = "recordCheatmealButton";
            recordCheatmealButton.Padding = new Padding(10, 0, 10, 0);
            recordCheatmealButton.Size = new Size(186, 42);
            recordCheatmealButton.TabIndex = 1;
            recordCheatmealButton.Text = "Cheatmeal";
            recordCheatmealButton.TextAlign = ContentAlignment.MiddleLeft;
            recordCheatmealButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            recordCheatmealButton.UseVisualStyleBackColor = true;
            recordCheatmealButton.Click += recordCheatmealButton_Click;
            recordCheatmealButton.Leave += recordCheatmealButton_Leave;
            // 
            // recordWorkoutButton
            // 
            recordWorkoutButton.Dock = DockStyle.Top;
            recordWorkoutButton.FlatAppearance.BorderSize = 0;
            recordWorkoutButton.FlatStyle = FlatStyle.Flat;
            recordWorkoutButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            recordWorkoutButton.ForeColor = Color.FromArgb(0, 126, 249);
            recordWorkoutButton.Image = Properties.Resources.flame;
            recordWorkoutButton.ImageAlign = ContentAlignment.MiddleRight;
            recordWorkoutButton.Location = new Point(0, 186);
            recordWorkoutButton.Margin = new Padding(10, 3, 10, 3);
            recordWorkoutButton.Name = "recordWorkoutButton";
            recordWorkoutButton.Padding = new Padding(10, 0, 10, 0);
            recordWorkoutButton.Size = new Size(186, 42);
            recordWorkoutButton.TabIndex = 1;
            recordWorkoutButton.Text = "Workout";
            recordWorkoutButton.TextAlign = ContentAlignment.MiddleLeft;
            recordWorkoutButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            recordWorkoutButton.UseVisualStyleBackColor = true;
            recordWorkoutButton.Click += recordWorkoutButton_Click;
            recordWorkoutButton.Leave += recordWorkoutButton_Leave;
            // 
            // dashboardButton
            // 
            dashboardButton.Dock = DockStyle.Top;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardButton.ForeColor = Color.FromArgb(0, 126, 249);
            dashboardButton.Image = Properties.Resources.home__1_;
            dashboardButton.ImageAlign = ContentAlignment.MiddleRight;
            dashboardButton.Location = new Point(0, 144);
            dashboardButton.Margin = new Padding(10, 3, 10, 3);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(10, 0, 10, 0);
            dashboardButton.Size = new Size(186, 42);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += dashboardButton_Click;
            dashboardButton.Leave += dashboardButton_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(userNameLabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 0;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.ForeColor = Color.FromArgb(0, 126, 249);
            userNameLabel.Location = new Point(47, 97);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(88, 21);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.empty_user_image;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = Color.FromArgb(0, 126, 249);
            navigationPanel.Location = new Point(0, 193);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(3, 100);
            navigationPanel.TabIndex = 1;
            // 
            // dashboardCustomControl1
            // 
            dashboardCustomControl1.Location = new Point(183, 35);
            dashboardCustomControl1.Margin = new Padding(4);
            dashboardCustomControl1.Name = "dashboardCustomControl1";
            dashboardCustomControl1.Size = new Size(768, 542);
            dashboardCustomControl1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateBlue;
            panel3.Controls.Add(closeMainFormButton);
            panel3.Location = new Point(183, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(768, 36);
            panel3.TabIndex = 3;
            // 
            // closeMainFormButton
            // 
            closeMainFormButton.Dock = DockStyle.Right;
            closeMainFormButton.FlatAppearance.BorderSize = 0;
            closeMainFormButton.FlatStyle = FlatStyle.Flat;
            closeMainFormButton.Image = Properties.Resources.close__2_;
            closeMainFormButton.Location = new Point(725, 0);
            closeMainFormButton.Name = "closeMainFormButton";
            closeMainFormButton.Size = new Size(43, 36);
            closeMainFormButton.TabIndex = 0;
            closeMainFormButton.UseVisualStyleBackColor = true;
            closeMainFormButton.Click += closeMainFormButton_Click;
            // 
            // workoutUserControlForm1
            // 
            workoutUserControlForm1.Location = new Point(183, 35);
            workoutUserControlForm1.Margin = new Padding(4);
            workoutUserControlForm1.Name = "workoutUserControlForm1";
            workoutUserControlForm1.Size = new Size(768, 542);
            workoutUserControlForm1.TabIndex = 4;
            // 
            // cheatmealUserControlForm1
            // 
            cheatmealUserControlForm1.Location = new Point(183, 35);
            cheatmealUserControlForm1.Margin = new Padding(4, 4, 4, 4);
            cheatmealUserControlForm1.Name = "cheatmealUserControlForm1";
            cheatmealUserControlForm1.Size = new Size(768, 542);
            cheatmealUserControlForm1.TabIndex = 5;
            // 
            // reportUserControlForm1
            // 
            reportUserControlForm1.Location = new Point(183, 35);
            reportUserControlForm1.Margin = new Padding(4, 4, 4, 4);
            reportUserControlForm1.Name = "reportUserControlForm1";
            reportUserControlForm1.Size = new Size(768, 542);
            reportUserControlForm1.TabIndex = 6;
            // 
            // predictionUserControlForm1
            // 
            predictionUserControlForm1.Location = new Point(183, 35);
            predictionUserControlForm1.Margin = new Padding(4, 4, 4, 4);
            predictionUserControlForm1.Name = "predictionUserControlForm1";
            predictionUserControlForm1.Size = new Size(764, 542);
            predictionUserControlForm1.TabIndex = 7;
            // 
            // profileUserControlForm1
            // 
            profileUserControlForm1.Location = new Point(183, 35);
            profileUserControlForm1.Margin = new Padding(4, 4, 4, 4);
            profileUserControlForm1.Name = "profileUserControlForm1";
            profileUserControlForm1.Size = new Size(768, 542);
            profileUserControlForm1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(profileUserControlForm1);
            Controls.Add(predictionUserControlForm1);
            Controls.Add(reportUserControlForm1);
            Controls.Add(cheatmealUserControlForm1);
            Controls.Add(workoutUserControlForm1);
            Controls.Add(panel3);
            Controls.Add(dashboardCustomControl1);
            Controls.Add(navigationPanel);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlashFit";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label userNameLabel;
        private Button dashboardButton;
        private Button logoutButton;
        private Button predictionButton;
        private Button reportButton;
        private Button recordCheatmealButton;
        private Button recordWorkoutButton;
        private Button profileButton;
        private Panel navigationPanel;
        private DashboardCustomControl dashboardCustomControl1;
        private Panel panel3;
        private Button closeMainFormButton;
        private WorkoutUserControlForm workoutUserControlForm1;
        private CheatmealUserControlForm cheatmealUserControlForm1;
        private ReportUserControlForm reportUserControlForm1;
        private PredictionUserControlForm predictionUserControlForm1;
        private ProfileUserControlForm profileUserControlForm1;
    }
}