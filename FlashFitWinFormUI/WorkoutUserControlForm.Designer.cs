namespace FlashFitWinFormUI
{
    partial class WorkoutUserControlForm
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
            addWorkoutFormButton = new Button();
            workoutRecordListView = new ListView();
            id = new ColumnHeader();
            name = new ColumnHeader();
            date = new ColumnHeader();
            calories = new ColumnHeader();
            weight = new ColumnHeader();
            saveWorkoutRecordButton = new Button();
            weightAtWorkoutLabel = new Label();
            selectWorkoutComboBox = new ComboBox();
            selectWorkoutLabel = new Label();
            selectWorkoutDateTimePicker = new Label();
            workedoutDateTimePicker = new DateTimePicker();
            weightAtWorkoutNumeric = new NumericUpDown();
            workoutRecordEditButton = new Button();
            workoutRecordDeleteButton = new Button();
            workoutRecordGroupBox = new GroupBox();
            hiddenRecordIDText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)weightAtWorkoutNumeric).BeginInit();
            workoutRecordGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // addWorkoutFormButton
            // 
            addWorkoutFormButton.FlatStyle = FlatStyle.Flat;
            addWorkoutFormButton.Location = new Point(23, 467);
            addWorkoutFormButton.Name = "addWorkoutFormButton";
            addWorkoutFormButton.Size = new Size(159, 36);
            addWorkoutFormButton.TabIndex = 1;
            addWorkoutFormButton.Text = "Add New Workout";
            addWorkoutFormButton.UseVisualStyleBackColor = true;
            addWorkoutFormButton.Click += addWorkoutFormButton_Click;
            // 
            // workoutRecordListView
            // 
            workoutRecordListView.BackColor = Color.FromArgb(46, 51, 73);
            workoutRecordListView.Columns.AddRange(new ColumnHeader[] { id, name, date, calories, weight });
            workoutRecordListView.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            workoutRecordListView.ForeColor = SystemColors.Window;
            workoutRecordListView.FullRowSelect = true;
            workoutRecordListView.Location = new Point(591, 21);
            workoutRecordListView.Name = "workoutRecordListView";
            workoutRecordListView.Size = new Size(410, 421);
            workoutRecordListView.TabIndex = 2;
            workoutRecordListView.UseCompatibleStateImageBehavior = false;
            workoutRecordListView.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 50;
            // 
            // name
            // 
            name.Text = "Workout";
            name.Width = 100;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 100;
            // 
            // calories
            // 
            calories.Text = "Calorie";
            calories.Width = 100;
            // 
            // weight
            // 
            weight.Text = "Weight";
            // 
            // saveWorkoutRecordButton
            // 
            saveWorkoutRecordButton.FlatStyle = FlatStyle.Flat;
            saveWorkoutRecordButton.Location = new Point(192, 286);
            saveWorkoutRecordButton.Name = "saveWorkoutRecordButton";
            saveWorkoutRecordButton.Size = new Size(143, 36);
            saveWorkoutRecordButton.TabIndex = 3;
            saveWorkoutRecordButton.Text = "Save";
            saveWorkoutRecordButton.UseVisualStyleBackColor = true;
            saveWorkoutRecordButton.Click += saveWorkoutRecordButton_Click;
            // 
            // weightAtWorkoutLabel
            // 
            weightAtWorkoutLabel.AutoSize = true;
            weightAtWorkoutLabel.Location = new Point(22, 174);
            weightAtWorkoutLabel.Name = "weightAtWorkoutLabel";
            weightAtWorkoutLabel.Size = new Size(161, 21);
            weightAtWorkoutLabel.TabIndex = 4;
            weightAtWorkoutLabel.Text = "Weight After Workout";
            // 
            // selectWorkoutComboBox
            // 
            selectWorkoutComboBox.FormattingEnabled = true;
            selectWorkoutComboBox.Location = new Point(192, 46);
            selectWorkoutComboBox.Name = "selectWorkoutComboBox";
            selectWorkoutComboBox.Size = new Size(249, 29);
            selectWorkoutComboBox.TabIndex = 5;
            // 
            // selectWorkoutLabel
            // 
            selectWorkoutLabel.AutoSize = true;
            selectWorkoutLabel.Location = new Point(22, 49);
            selectWorkoutLabel.Name = "selectWorkoutLabel";
            selectWorkoutLabel.Size = new Size(115, 21);
            selectWorkoutLabel.TabIndex = 4;
            selectWorkoutLabel.Text = "Select Workout";
            // 
            // selectWorkoutDateTimePicker
            // 
            selectWorkoutDateTimePicker.AutoSize = true;
            selectWorkoutDateTimePicker.Location = new Point(22, 111);
            selectWorkoutDateTimePicker.Name = "selectWorkoutDateTimePicker";
            selectWorkoutDateTimePicker.Size = new Size(87, 21);
            selectWorkoutDateTimePicker.TabIndex = 4;
            selectWorkoutDateTimePicker.Text = "Select Date";
            // 
            // workedoutDateTimePicker
            // 
            workedoutDateTimePicker.Checked = false;
            workedoutDateTimePicker.CustomFormat = "yyyy-MMM-dd hh:MM tt";
            workedoutDateTimePicker.Format = DateTimePickerFormat.Custom;
            workedoutDateTimePicker.Location = new Point(192, 105);
            workedoutDateTimePicker.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            workedoutDateTimePicker.Name = "workedoutDateTimePicker";
            workedoutDateTimePicker.Size = new Size(249, 29);
            workedoutDateTimePicker.TabIndex = 6;
            // 
            // weightAtWorkoutNumeric
            // 
            weightAtWorkoutNumeric.Location = new Point(192, 172);
            weightAtWorkoutNumeric.Name = "weightAtWorkoutNumeric";
            weightAtWorkoutNumeric.Size = new Size(120, 29);
            weightAtWorkoutNumeric.TabIndex = 7;
            // 
            // workoutRecordEditButton
            // 
            workoutRecordEditButton.FlatStyle = FlatStyle.Flat;
            workoutRecordEditButton.Location = new Point(591, 467);
            workoutRecordEditButton.Name = "workoutRecordEditButton";
            workoutRecordEditButton.Size = new Size(143, 36);
            workoutRecordEditButton.TabIndex = 3;
            workoutRecordEditButton.Text = "Edit";
            workoutRecordEditButton.UseVisualStyleBackColor = true;
            workoutRecordEditButton.Click += workoutRecordEditButton_Click;
            // 
            // workoutRecordDeleteButton
            // 
            workoutRecordDeleteButton.FlatStyle = FlatStyle.Flat;
            workoutRecordDeleteButton.Location = new Point(773, 467);
            workoutRecordDeleteButton.Name = "workoutRecordDeleteButton";
            workoutRecordDeleteButton.Size = new Size(143, 36);
            workoutRecordDeleteButton.TabIndex = 3;
            workoutRecordDeleteButton.Text = "Delete";
            workoutRecordDeleteButton.UseVisualStyleBackColor = true;
            workoutRecordDeleteButton.Click += workoutRecordDeleteButton_Click;
            // 
            // workoutRecordGroupBox
            // 
            workoutRecordGroupBox.Controls.Add(hiddenRecordIDText);
            workoutRecordGroupBox.Controls.Add(weightAtWorkoutNumeric);
            workoutRecordGroupBox.Controls.Add(selectWorkoutLabel);
            workoutRecordGroupBox.Controls.Add(workedoutDateTimePicker);
            workoutRecordGroupBox.Controls.Add(selectWorkoutDateTimePicker);
            workoutRecordGroupBox.Controls.Add(selectWorkoutComboBox);
            workoutRecordGroupBox.Controls.Add(weightAtWorkoutLabel);
            workoutRecordGroupBox.Controls.Add(saveWorkoutRecordButton);
            workoutRecordGroupBox.ForeColor = SystemColors.ControlLightLight;
            workoutRecordGroupBox.Location = new Point(23, 21);
            workoutRecordGroupBox.Name = "workoutRecordGroupBox";
            workoutRecordGroupBox.Size = new Size(478, 363);
            workoutRecordGroupBox.TabIndex = 8;
            workoutRecordGroupBox.TabStop = false;
            workoutRecordGroupBox.Text = "Workout Record";
            // 
            // hiddenRecordIDText
            // 
            hiddenRecordIDText.Enabled = false;
            hiddenRecordIDText.Location = new Point(194, 222);
            hiddenRecordIDText.Name = "hiddenRecordIDText";
            hiddenRecordIDText.Size = new Size(62, 29);
            hiddenRecordIDText.TabIndex = 8;
            hiddenRecordIDText.Visible = false;
            // 
            // WorkoutUserControlForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(workoutRecordDeleteButton);
            Controls.Add(workoutRecordEditButton);
            Controls.Add(workoutRecordListView);
            Controls.Add(addWorkoutFormButton);
            Controls.Add(workoutRecordGroupBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HighlightText;
            Margin = new Padding(4);
            Name = "WorkoutUserControlForm";
            Size = new Size(1042, 528);
            Load += WorkoutUserControlForm_Load;
            ((System.ComponentModel.ISupportInitialize)weightAtWorkoutNumeric).EndInit();
            workoutRecordGroupBox.ResumeLayout(false);
            workoutRecordGroupBox.PerformLayout();
            ResumeLayout(false);
        }



        #endregion
        private Button addWorkoutFormButton;
        private ListView workoutRecordListView;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader date;
        private ColumnHeader calories;
        private Button saveWorkoutRecordButton;
        private Label weightAtWorkoutLabel;
        private ComboBox selectWorkoutComboBox;
        private Label selectWorkoutLabel;
        private Label selectWorkoutDateTimePicker;
        private DateTimePicker workedoutDateTimePicker;
        private NumericUpDown weightAtWorkoutNumeric;
        private ColumnHeader weight;
        private Button workoutRecordEditButton;
        private Button workoutRecordDeleteButton;
        private GroupBox workoutRecordGroupBox;
        private TextBox hiddenRecordIDText;
    }
}
