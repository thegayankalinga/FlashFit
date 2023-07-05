namespace FlashFitWinFormUI
{
    partial class AddWorkoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkoutForm));
            saveWorkoutButton = new Button();
            workoutNameLabel = new Label();
            workoutNameText = new TextBox();
            workoutTypeLabel = new Label();
            caloriesBurnRateLabel = new Label();
            workoutTypeComboBox = new ComboBox();
            caloriesBurnRateNumeric = new NumericUpDown();
            workoutIdLabel = new Label();
            workoutIdText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)caloriesBurnRateNumeric).BeginInit();
            SuspendLayout();
            // 
            // saveWorkoutButton
            // 
            saveWorkoutButton.FlatStyle = FlatStyle.Flat;
            saveWorkoutButton.Location = new Point(210, 382);
            saveWorkoutButton.Name = "saveWorkoutButton";
            saveWorkoutButton.Size = new Size(200, 54);
            saveWorkoutButton.TabIndex = 0;
            saveWorkoutButton.Text = "Save";
            saveWorkoutButton.UseVisualStyleBackColor = true;
            saveWorkoutButton.Click += saveWorkoutButton_Click;
            // 
            // workoutNameLabel
            // 
            workoutNameLabel.AutoSize = true;
            workoutNameLabel.Location = new Point(36, 86);
            workoutNameLabel.Name = "workoutNameLabel";
            workoutNameLabel.Size = new Size(116, 21);
            workoutNameLabel.TabIndex = 1;
            workoutNameLabel.Text = "Workout Name";
            // 
            // workoutNameText
            // 
            workoutNameText.Location = new Point(210, 83);
            workoutNameText.Name = "workoutNameText";
            workoutNameText.Size = new Size(242, 29);
            workoutNameText.TabIndex = 2;
            // 
            // workoutTypeLabel
            // 
            workoutTypeLabel.AutoSize = true;
            workoutTypeLabel.Location = new Point(36, 169);
            workoutTypeLabel.Name = "workoutTypeLabel";
            workoutTypeLabel.Size = new Size(106, 21);
            workoutTypeLabel.TabIndex = 1;
            workoutTypeLabel.Text = "Workout Type";
            // 
            // caloriesBurnRateLabel
            // 
            caloriesBurnRateLabel.AutoSize = true;
            caloriesBurnRateLabel.Location = new Point(36, 257);
            caloriesBurnRateLabel.Name = "caloriesBurnRateLabel";
            caloriesBurnRateLabel.Size = new Size(121, 21);
            caloriesBurnRateLabel.TabIndex = 1;
            caloriesBurnRateLabel.Text = "Calories to Burn";
            // 
            // workoutTypeComboBox
            // 
            workoutTypeComboBox.FormattingEnabled = true;
            workoutTypeComboBox.Location = new Point(210, 166);
            workoutTypeComboBox.Name = "workoutTypeComboBox";
            workoutTypeComboBox.Size = new Size(242, 29);
            workoutTypeComboBox.TabIndex = 3;
            // 
            // caloriesBurnRateNumeric
            // 
            caloriesBurnRateNumeric.Location = new Point(210, 249);
            caloriesBurnRateNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            caloriesBurnRateNumeric.Name = "caloriesBurnRateNumeric";
            caloriesBurnRateNumeric.Size = new Size(142, 29);
            caloriesBurnRateNumeric.TabIndex = 4;
            caloriesBurnRateNumeric.TextAlign = HorizontalAlignment.Right;
            caloriesBurnRateNumeric.ThousandsSeparator = true;
            // 
            // workoutIdLabel
            // 
            workoutIdLabel.AutoSize = true;
            workoutIdLabel.Location = new Point(36, 28);
            workoutIdLabel.Name = "workoutIdLabel";
            workoutIdLabel.Size = new Size(25, 21);
            workoutIdLabel.TabIndex = 1;
            workoutIdLabel.Text = "ID";
            // 
            // workoutIdText
            // 
            workoutIdText.Location = new Point(210, 28);
            workoutIdText.Name = "workoutIdText";
            workoutIdText.Size = new Size(242, 29);
            workoutIdText.TabIndex = 2;
            // 
            // AddWorkoutForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1029, 630);
            Controls.Add(caloriesBurnRateNumeric);
            Controls.Add(workoutTypeComboBox);
            Controls.Add(workoutIdText);
            Controls.Add(workoutNameText);
            Controls.Add(caloriesBurnRateLabel);
            Controls.Add(workoutIdLabel);
            Controls.Add(workoutTypeLabel);
            Controls.Add(workoutNameLabel);
            Controls.Add(saveWorkoutButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HighlightText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AddWorkoutForm";
            Text = "Add Workout";
            Load += AddWorkoutForm_Load;
            ((System.ComponentModel.ISupportInitialize)caloriesBurnRateNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveWorkoutButton;
        private Label workoutNameLabel;
        private TextBox workoutNameText;
        private Label workoutTypeLabel;
        private Label caloriesBurnRateLabel;
        private ComboBox workoutTypeComboBox;
        private NumericUpDown caloriesBurnRateNumeric;
        private Label workoutIdLabel;
        private TextBox workoutIdText;
    }
}