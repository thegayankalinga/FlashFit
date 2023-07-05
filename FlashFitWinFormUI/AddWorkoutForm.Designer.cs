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
            workoutListView = new ListView();
            idHeader = new ColumnHeader("(none)");
            nameHeader = new ColumnHeader();
            typeHeader = new ColumnHeader();
            caloryHeader = new ColumnHeader();
            editWorkoutButton = new Button();
            deleteWorkoutButton = new Button();
            workoutAddGroupBox = new GroupBox();
            hiddenWorkoutIDText = new TextBox();
            caloriesSubLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)caloriesBurnRateNumeric).BeginInit();
            workoutAddGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // saveWorkoutButton
            // 
            saveWorkoutButton.FlatStyle = FlatStyle.Flat;
            saveWorkoutButton.Location = new Point(174, 292);
            saveWorkoutButton.Name = "saveWorkoutButton";
            saveWorkoutButton.Size = new Size(200, 44);
            saveWorkoutButton.TabIndex = 0;
            saveWorkoutButton.Text = "Save";
            saveWorkoutButton.UseVisualStyleBackColor = true;
            saveWorkoutButton.Click += saveWorkoutButton_Click;
            // 
            // workoutNameLabel
            // 
            workoutNameLabel.AutoSize = true;
            workoutNameLabel.Location = new Point(10, 56);
            workoutNameLabel.Name = "workoutNameLabel";
            workoutNameLabel.Size = new Size(116, 21);
            workoutNameLabel.TabIndex = 1;
            workoutNameLabel.Text = "Workout Name";
            // 
            // workoutNameText
            // 
            workoutNameText.Location = new Point(174, 53);
            workoutNameText.Name = "workoutNameText";
            workoutNameText.Size = new Size(242, 29);
            workoutNameText.TabIndex = 2;
            // 
            // workoutTypeLabel
            // 
            workoutTypeLabel.AutoSize = true;
            workoutTypeLabel.Location = new Point(10, 136);
            workoutTypeLabel.Name = "workoutTypeLabel";
            workoutTypeLabel.Size = new Size(106, 21);
            workoutTypeLabel.TabIndex = 1;
            workoutTypeLabel.Text = "Workout Type";
            // 
            // caloriesBurnRateLabel
            // 
            caloriesBurnRateLabel.AutoSize = true;
            caloriesBurnRateLabel.Location = new Point(10, 219);
            caloriesBurnRateLabel.Name = "caloriesBurnRateLabel";
            caloriesBurnRateLabel.Size = new Size(121, 21);
            caloriesBurnRateLabel.TabIndex = 1;
            caloriesBurnRateLabel.Text = "Calories to Burn";
            // 
            // workoutTypeComboBox
            // 
            workoutTypeComboBox.FormattingEnabled = true;
            workoutTypeComboBox.Location = new Point(174, 133);
            workoutTypeComboBox.Name = "workoutTypeComboBox";
            workoutTypeComboBox.Size = new Size(242, 29);
            workoutTypeComboBox.TabIndex = 3;
            // 
            // caloriesBurnRateNumeric
            // 
            caloriesBurnRateNumeric.Location = new Point(174, 217);
            caloriesBurnRateNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            caloriesBurnRateNumeric.Name = "caloriesBurnRateNumeric";
            caloriesBurnRateNumeric.Size = new Size(142, 29);
            caloriesBurnRateNumeric.TabIndex = 4;
            caloriesBurnRateNumeric.TextAlign = HorizontalAlignment.Right;
            caloriesBurnRateNumeric.ThousandsSeparator = true;
            // 
            // workoutListView
            // 
            workoutListView.BackColor = Color.FromArgb(46, 51, 73);
            workoutListView.BorderStyle = BorderStyle.None;
            workoutListView.Columns.AddRange(new ColumnHeader[] { idHeader, nameHeader, typeHeader, caloryHeader });
            workoutListView.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            workoutListView.ForeColor = SystemColors.Window;
            workoutListView.FullRowSelect = true;
            workoutListView.Location = new Point(532, 27);
            workoutListView.MultiSelect = false;
            workoutListView.Name = "workoutListView";
            workoutListView.Size = new Size(463, 528);
            workoutListView.TabIndex = 5;
            workoutListView.UseCompatibleStateImageBehavior = false;
            workoutListView.View = View.Details;
            // 
            // idHeader
            // 
            idHeader.Text = "ID";
            // 
            // nameHeader
            // 
            nameHeader.Text = "Name";
            nameHeader.Width = 150;
            // 
            // typeHeader
            // 
            typeHeader.Text = "Type";
            typeHeader.Width = 150;
            // 
            // caloryHeader
            // 
            caloryHeader.Text = "Calories";
            caloryHeader.TextAlign = HorizontalAlignment.Right;
            caloryHeader.Width = 100;
            // 
            // editWorkoutButton
            // 
            editWorkoutButton.FlatStyle = FlatStyle.Flat;
            editWorkoutButton.Location = new Point(532, 578);
            editWorkoutButton.Name = "editWorkoutButton";
            editWorkoutButton.Size = new Size(130, 40);
            editWorkoutButton.TabIndex = 6;
            editWorkoutButton.Text = "Edit";
            editWorkoutButton.UseVisualStyleBackColor = true;
            editWorkoutButton.Click += editWorkoutButton_Click;
            // 
            // deleteWorkoutButton
            // 
            deleteWorkoutButton.FlatStyle = FlatStyle.Flat;
            deleteWorkoutButton.Location = new Point(700, 578);
            deleteWorkoutButton.Name = "deleteWorkoutButton";
            deleteWorkoutButton.Size = new Size(130, 40);
            deleteWorkoutButton.TabIndex = 6;
            deleteWorkoutButton.Text = "Delete";
            deleteWorkoutButton.UseVisualStyleBackColor = true;
            deleteWorkoutButton.Click += deleteWorkoutButton_Click;
            // 
            // workoutAddGroupBox
            // 
            workoutAddGroupBox.Controls.Add(hiddenWorkoutIDText);
            workoutAddGroupBox.Controls.Add(caloriesSubLabel);
            workoutAddGroupBox.Controls.Add(saveWorkoutButton);
            workoutAddGroupBox.Controls.Add(caloriesBurnRateLabel);
            workoutAddGroupBox.Controls.Add(caloriesBurnRateNumeric);
            workoutAddGroupBox.Controls.Add(workoutNameLabel);
            workoutAddGroupBox.Controls.Add(workoutNameText);
            workoutAddGroupBox.Controls.Add(workoutTypeComboBox);
            workoutAddGroupBox.Controls.Add(workoutTypeLabel);
            workoutAddGroupBox.ForeColor = SystemColors.HighlightText;
            workoutAddGroupBox.Location = new Point(31, 27);
            workoutAddGroupBox.Name = "workoutAddGroupBox";
            workoutAddGroupBox.Size = new Size(460, 387);
            workoutAddGroupBox.TabIndex = 7;
            workoutAddGroupBox.TabStop = false;
            workoutAddGroupBox.Text = "Add New Workout";
            // 
            // hiddenWorkoutIDText
            // 
            hiddenWorkoutIDText.Enabled = false;
            hiddenWorkoutIDText.Location = new Point(174, 18);
            hiddenWorkoutIDText.Name = "hiddenWorkoutIDText";
            hiddenWorkoutIDText.Size = new Size(61, 29);
            hiddenWorkoutIDText.TabIndex = 8;
            hiddenWorkoutIDText.Visible = false;
            // 
            // caloriesSubLabel
            // 
            caloriesSubLabel.AutoSize = true;
            caloriesSubLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            caloriesSubLabel.ForeColor = SystemColors.ControlDark;
            caloriesSubLabel.Location = new Point(10, 240);
            caloriesSubLabel.Name = "caloriesSubLabel";
            caloriesSubLabel.Size = new Size(51, 13);
            caloriesSubLabel.TabIndex = 8;
            caloriesSubLabel.Text = "optional";
            // 
            // AddWorkoutForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1029, 630);
            Controls.Add(deleteWorkoutButton);
            Controls.Add(editWorkoutButton);
            Controls.Add(workoutListView);
            Controls.Add(workoutAddGroupBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HighlightText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AddWorkoutForm";
            Text = "Add Workout";
            Load += AddWorkoutForm_Load;
            ((System.ComponentModel.ISupportInitialize)caloriesBurnRateNumeric).EndInit();
            workoutAddGroupBox.ResumeLayout(false);
            workoutAddGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button saveWorkoutButton;
        private Label workoutNameLabel;
        private TextBox workoutNameText;
        private Label workoutTypeLabel;
        private Label caloriesBurnRateLabel;
        private ComboBox workoutTypeComboBox;
        private NumericUpDown caloriesBurnRateNumeric;
        private ListView workoutListView;
        private Button editWorkoutButton;
        private Button deleteWorkoutButton;
        private ColumnHeader idHeader;
        private ColumnHeader nameHeader;
        private ColumnHeader typeHeader;
        private ColumnHeader caloryHeader;
        private GroupBox workoutAddGroupBox;
        private Label caloriesSubLabel;
        private TextBox hiddenWorkoutIDText;
    }
}