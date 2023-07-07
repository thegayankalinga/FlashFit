namespace FlashFitWinFormUI
{
    partial class CheatmealUserControlForm
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
            addCheatMealButton = new Button();
            cheatmealRecordGroupBox = new GroupBox();
            hiddenCheatmealRecordIDText = new TextBox();
            weightAtCheatmealNumeric = new NumericUpDown();
            selectCheatmealLabel = new Label();
            cheatmealDateTimePicker = new DateTimePicker();
            selectCheatmealDateTimePicker = new Label();
            selectCheatmealComboBox = new ComboBox();
            weightAtCheatmealLabel = new Label();
            saveCheatmealRecordButton = new Button();
            cheatmealRecordDeleteButton = new Button();
            cheatmealRecordEditButton = new Button();
            cheatmealRecordListView = new ListView();
            id = new ColumnHeader();
            name = new ColumnHeader();
            date = new ColumnHeader();
            calories = new ColumnHeader();
            weight = new ColumnHeader();
            cheatmealRecordGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weightAtCheatmealNumeric).BeginInit();
            SuspendLayout();
            // 
            // addCheatMealButton
            // 
            addCheatMealButton.FlatStyle = FlatStyle.Flat;
            addCheatMealButton.ForeColor = SystemColors.HighlightText;
            addCheatMealButton.Location = new Point(28, 405);
            addCheatMealButton.Margin = new Padding(4);
            addCheatMealButton.Name = "addCheatMealButton";
            addCheatMealButton.Size = new Size(172, 42);
            addCheatMealButton.TabIndex = 1;
            addCheatMealButton.Text = "Add New Cheatmeal";
            addCheatMealButton.UseVisualStyleBackColor = true;
            addCheatMealButton.Click += addCheatMealButton_Click;
            // 
            // cheatmealRecordGroupBox
            // 
            cheatmealRecordGroupBox.Controls.Add(hiddenCheatmealRecordIDText);
            cheatmealRecordGroupBox.Controls.Add(weightAtCheatmealNumeric);
            cheatmealRecordGroupBox.Controls.Add(selectCheatmealLabel);
            cheatmealRecordGroupBox.Controls.Add(cheatmealDateTimePicker);
            cheatmealRecordGroupBox.Controls.Add(selectCheatmealDateTimePicker);
            cheatmealRecordGroupBox.Controls.Add(selectCheatmealComboBox);
            cheatmealRecordGroupBox.Controls.Add(weightAtCheatmealLabel);
            cheatmealRecordGroupBox.Controls.Add(saveCheatmealRecordButton);
            cheatmealRecordGroupBox.ForeColor = SystemColors.ControlLightLight;
            cheatmealRecordGroupBox.Location = new Point(28, 26);
            cheatmealRecordGroupBox.Name = "cheatmealRecordGroupBox";
            cheatmealRecordGroupBox.Size = new Size(478, 353);
            cheatmealRecordGroupBox.TabIndex = 9;
            cheatmealRecordGroupBox.TabStop = false;
            cheatmealRecordGroupBox.Text = "Cheatmeal Record";
            // 
            // hiddenCheatmealRecordIDText
            // 
            hiddenCheatmealRecordIDText.Enabled = false;
            hiddenCheatmealRecordIDText.HideSelection = false;
            hiddenCheatmealRecordIDText.Location = new Point(203, 222);
            hiddenCheatmealRecordIDText.Name = "hiddenCheatmealRecordIDText";
            hiddenCheatmealRecordIDText.Size = new Size(62, 29);
            hiddenCheatmealRecordIDText.TabIndex = 8;
            hiddenCheatmealRecordIDText.Visible = false;
            // 
            // weightAtCheatmealNumeric
            // 
            weightAtCheatmealNumeric.Location = new Point(203, 166);
            weightAtCheatmealNumeric.Name = "weightAtCheatmealNumeric";
            weightAtCheatmealNumeric.Size = new Size(120, 29);
            weightAtCheatmealNumeric.TabIndex = 7;
            // 
            // selectCheatmealLabel
            // 
            selectCheatmealLabel.AutoSize = true;
            selectCheatmealLabel.Location = new Point(22, 49);
            selectCheatmealLabel.Name = "selectCheatmealLabel";
            selectCheatmealLabel.Size = new Size(129, 21);
            selectCheatmealLabel.TabIndex = 4;
            selectCheatmealLabel.Text = "Select Cheatmeal";
            // 
            // cheatmealDateTimePicker
            // 
            cheatmealDateTimePicker.Checked = false;
            cheatmealDateTimePicker.CustomFormat = "yyyy-MMM-dd hh:MM tt";
            cheatmealDateTimePicker.Format = DateTimePickerFormat.Custom;
            cheatmealDateTimePicker.Location = new Point(203, 105);
            cheatmealDateTimePicker.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            cheatmealDateTimePicker.Name = "cheatmealDateTimePicker";
            cheatmealDateTimePicker.Size = new Size(238, 29);
            cheatmealDateTimePicker.TabIndex = 6;
            // 
            // selectCheatmealDateTimePicker
            // 
            selectCheatmealDateTimePicker.AutoSize = true;
            selectCheatmealDateTimePicker.Location = new Point(22, 111);
            selectCheatmealDateTimePicker.Name = "selectCheatmealDateTimePicker";
            selectCheatmealDateTimePicker.Size = new Size(87, 21);
            selectCheatmealDateTimePicker.TabIndex = 4;
            selectCheatmealDateTimePicker.Text = "Select Date";
            // 
            // selectCheatmealComboBox
            // 
            selectCheatmealComboBox.FormattingEnabled = true;
            selectCheatmealComboBox.Location = new Point(203, 46);
            selectCheatmealComboBox.Name = "selectCheatmealComboBox";
            selectCheatmealComboBox.Size = new Size(238, 29);
            selectCheatmealComboBox.TabIndex = 5;
            // 
            // weightAtCheatmealLabel
            // 
            weightAtCheatmealLabel.AutoSize = true;
            weightAtCheatmealLabel.Location = new Point(22, 174);
            weightAtCheatmealLabel.Name = "weightAtCheatmealLabel";
            weightAtCheatmealLabel.Size = new Size(175, 21);
            weightAtCheatmealLabel.TabIndex = 4;
            weightAtCheatmealLabel.Text = "Weight After Cheatmeal";
            // 
            // saveCheatmealRecordButton
            // 
            saveCheatmealRecordButton.FlatStyle = FlatStyle.Flat;
            saveCheatmealRecordButton.Location = new Point(192, 286);
            saveCheatmealRecordButton.Name = "saveCheatmealRecordButton";
            saveCheatmealRecordButton.Size = new Size(143, 36);
            saveCheatmealRecordButton.TabIndex = 3;
            saveCheatmealRecordButton.Text = "Save";
            saveCheatmealRecordButton.UseVisualStyleBackColor = true;
            saveCheatmealRecordButton.Click += saveCheatmealRecordButton_Click;
            // 
            // cheatmealRecordDeleteButton
            // 
            cheatmealRecordDeleteButton.FlatStyle = FlatStyle.Flat;
            cheatmealRecordDeleteButton.ForeColor = SystemColors.HighlightText;
            cheatmealRecordDeleteButton.Location = new Point(809, 471);
            cheatmealRecordDeleteButton.Name = "cheatmealRecordDeleteButton";
            cheatmealRecordDeleteButton.Size = new Size(143, 36);
            cheatmealRecordDeleteButton.TabIndex = 12;
            cheatmealRecordDeleteButton.Text = "Delete";
            cheatmealRecordDeleteButton.UseVisualStyleBackColor = true;
            cheatmealRecordDeleteButton.Click += workoutRecordDeleteButton_Click;
            // 
            // cheatmealRecordEditButton
            // 
            cheatmealRecordEditButton.FlatStyle = FlatStyle.Flat;
            cheatmealRecordEditButton.ForeColor = SystemColors.HighlightText;
            cheatmealRecordEditButton.Location = new Point(627, 471);
            cheatmealRecordEditButton.Name = "cheatmealRecordEditButton";
            cheatmealRecordEditButton.Size = new Size(143, 36);
            cheatmealRecordEditButton.TabIndex = 11;
            cheatmealRecordEditButton.Text = "Edit";
            cheatmealRecordEditButton.UseVisualStyleBackColor = true;
            cheatmealRecordEditButton.Click += workoutRecordEditButton_Click;
            // 
            // cheatmealRecordListView
            // 
            cheatmealRecordListView.BackColor = Color.FromArgb(46, 51, 73);
            cheatmealRecordListView.Columns.AddRange(new ColumnHeader[] { id, name, date, calories, weight });
            cheatmealRecordListView.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cheatmealRecordListView.ForeColor = SystemColors.Window;
            cheatmealRecordListView.FullRowSelect = true;
            cheatmealRecordListView.Location = new Point(574, 26);
            cheatmealRecordListView.Name = "cheatmealRecordListView";
            cheatmealRecordListView.Size = new Size(420, 421);
            cheatmealRecordListView.TabIndex = 10;
            cheatmealRecordListView.UseCompatibleStateImageBehavior = false;
            cheatmealRecordListView.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 30;
            // 
            // name
            // 
            name.Text = "Cheatmeal";
            name.Width = 100;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 150;
            // 
            // calories
            // 
            calories.Text = "Calorie Gain";
            calories.TextAlign = HorizontalAlignment.Right;
            calories.Width = 70;
            // 
            // weight
            // 
            weight.Text = "Weight";
            // 
            // CheatmealUserControlForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(cheatmealRecordDeleteButton);
            Controls.Add(cheatmealRecordEditButton);
            Controls.Add(cheatmealRecordListView);
            Controls.Add(cheatmealRecordGroupBox);
            Controls.Add(addCheatMealButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CheatmealUserControlForm";
            Size = new Size(1042, 528);
            Load += CheatmealUserControlForm_Load;
            cheatmealRecordGroupBox.ResumeLayout(false);
            cheatmealRecordGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weightAtCheatmealNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addCheatMealButton;
        private GroupBox cheatmealRecordGroupBox;
        private TextBox hiddenCheatmealRecordIDText;
        private NumericUpDown weightAtCheatmealNumeric;
        private Label selectCheatmealLabel;
        private DateTimePicker cheatmealDateTimePicker;
        private Label selectCheatmealDateTimePicker;
        private ComboBox selectCheatmealComboBox;
        private Label weightAtCheatmealLabel;
        private Button saveCheatmealRecordButton;
        private Button workoutRecordDeleteButton;
        private Button workoutRecordEditButton;
        private ListView cheatmealRecordListView;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader date;
        private ColumnHeader calories;
        private ColumnHeader weight;
        private Button cheatmealRecordDeleteButton;
        private Button cheatmealRecordEditButton;
    }
}
