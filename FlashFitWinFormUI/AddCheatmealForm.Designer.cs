namespace FlashFitWinFormUI
{
    partial class AddCheatmealForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCheatmealForm));
            cheatmealListView = new ListView();
            idHeader = new ColumnHeader("(none)");
            nameHeader = new ColumnHeader();
            caloryHeader = new ColumnHeader();
            cheatmealAddGroupBox = new GroupBox();
            hiddenCheatmealIDText = new TextBox();
            caloriesSubLabel = new Label();
            saveCheatmealButton = new Button();
            caloriesGainRateLabel = new Label();
            caloriesGainRateNumeric = new NumericUpDown();
            cheatmealNameLabel = new Label();
            cheatmealNameText = new TextBox();
            deleteCheatmealButton = new Button();
            editCheatmealButton = new Button();
            cheatmealAddGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)caloriesGainRateNumeric).BeginInit();
            SuspendLayout();
            // 
            // cheatmealListView
            // 
            cheatmealListView.BackColor = Color.FromArgb(46, 51, 73);
            cheatmealListView.BorderStyle = BorderStyle.None;
            cheatmealListView.Columns.AddRange(new ColumnHeader[] { idHeader, nameHeader, caloryHeader });
            cheatmealListView.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cheatmealListView.ForeColor = SystemColors.HighlightText;
            cheatmealListView.FullRowSelect = true;
            cheatmealListView.Location = new Point(509, 26);
            cheatmealListView.MultiSelect = false;
            cheatmealListView.Name = "cheatmealListView";
            cheatmealListView.Size = new Size(315, 419);
            cheatmealListView.TabIndex = 6;
            cheatmealListView.UseCompatibleStateImageBehavior = false;
            cheatmealListView.View = View.Details;
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
            // caloryHeader
            // 
            caloryHeader.Text = "Calories";
            caloryHeader.TextAlign = HorizontalAlignment.Right;
            caloryHeader.Width = 100;
            // 
            // cheatmealAddGroupBox
            // 
            cheatmealAddGroupBox.Controls.Add(hiddenCheatmealIDText);
            cheatmealAddGroupBox.Controls.Add(caloriesSubLabel);
            cheatmealAddGroupBox.Controls.Add(saveCheatmealButton);
            cheatmealAddGroupBox.Controls.Add(caloriesGainRateLabel);
            cheatmealAddGroupBox.Controls.Add(caloriesGainRateNumeric);
            cheatmealAddGroupBox.Controls.Add(cheatmealNameLabel);
            cheatmealAddGroupBox.Controls.Add(cheatmealNameText);
            cheatmealAddGroupBox.ForeColor = SystemColors.HighlightText;
            cheatmealAddGroupBox.Location = new Point(12, 26);
            cheatmealAddGroupBox.Name = "cheatmealAddGroupBox";
            cheatmealAddGroupBox.Size = new Size(460, 277);
            cheatmealAddGroupBox.TabIndex = 8;
            cheatmealAddGroupBox.TabStop = false;
            cheatmealAddGroupBox.Text = "Add New Cheatmeal";
            // 
            // hiddenCheatmealIDText
            // 
            hiddenCheatmealIDText.Enabled = false;
            hiddenCheatmealIDText.Location = new Point(10, 155);
            hiddenCheatmealIDText.Name = "hiddenCheatmealIDText";
            hiddenCheatmealIDText.Size = new Size(61, 29);
            hiddenCheatmealIDText.TabIndex = 8;
            hiddenCheatmealIDText.Visible = false;
            // 
            // caloriesSubLabel
            // 
            caloriesSubLabel.AutoSize = true;
            caloriesSubLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            caloriesSubLabel.ForeColor = SystemColors.ControlDark;
            caloriesSubLabel.Location = new Point(10, 127);
            caloriesSubLabel.Name = "caloriesSubLabel";
            caloriesSubLabel.Size = new Size(51, 13);
            caloriesSubLabel.TabIndex = 8;
            caloriesSubLabel.Text = "optional";
            // 
            // saveCheatmealButton
            // 
            saveCheatmealButton.FlatStyle = FlatStyle.Flat;
            saveCheatmealButton.Location = new Point(174, 192);
            saveCheatmealButton.Name = "saveCheatmealButton";
            saveCheatmealButton.Size = new Size(200, 44);
            saveCheatmealButton.TabIndex = 0;
            saveCheatmealButton.Text = "Save";
            saveCheatmealButton.UseVisualStyleBackColor = true;
            saveCheatmealButton.Click += saveCheatmealButton_Click;
            // 
            // caloriesGainRateLabel
            // 
            caloriesGainRateLabel.AutoSize = true;
            caloriesGainRateLabel.Location = new Point(10, 106);
            caloriesGainRateLabel.Name = "caloriesGainRateLabel";
            caloriesGainRateLabel.Size = new Size(120, 21);
            caloriesGainRateLabel.TabIndex = 1;
            caloriesGainRateLabel.Text = "Calories to Gain";
            // 
            // caloriesGainRateNumeric
            // 
            caloriesGainRateNumeric.Location = new Point(174, 104);
            caloriesGainRateNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            caloriesGainRateNumeric.Name = "caloriesGainRateNumeric";
            caloriesGainRateNumeric.Size = new Size(142, 29);
            caloriesGainRateNumeric.TabIndex = 4;
            caloriesGainRateNumeric.TextAlign = HorizontalAlignment.Right;
            caloriesGainRateNumeric.ThousandsSeparator = true;
            // 
            // cheatmealNameLabel
            // 
            cheatmealNameLabel.AutoSize = true;
            cheatmealNameLabel.Location = new Point(10, 40);
            cheatmealNameLabel.Name = "cheatmealNameLabel";
            cheatmealNameLabel.Size = new Size(130, 21);
            cheatmealNameLabel.TabIndex = 1;
            cheatmealNameLabel.Text = "Cheatmeal Name";
            // 
            // cheatmealNameText
            // 
            cheatmealNameText.Location = new Point(174, 37);
            cheatmealNameText.Name = "cheatmealNameText";
            cheatmealNameText.Size = new Size(242, 29);
            cheatmealNameText.TabIndex = 2;
            // 
            // deleteCheatmealButton
            // 
            deleteCheatmealButton.FlatStyle = FlatStyle.Flat;
            deleteCheatmealButton.ForeColor = SystemColors.HighlightText;
            deleteCheatmealButton.Location = new Point(694, 478);
            deleteCheatmealButton.Name = "deleteCheatmealButton";
            deleteCheatmealButton.Size = new Size(130, 40);
            deleteCheatmealButton.TabIndex = 9;
            deleteCheatmealButton.Text = "Delete";
            deleteCheatmealButton.UseVisualStyleBackColor = true;
            deleteCheatmealButton.Click += deleteCheatmealButton_Click;
            // 
            // editCheatmealButton
            // 
            editCheatmealButton.FlatStyle = FlatStyle.Flat;
            editCheatmealButton.ForeColor = SystemColors.HighlightText;
            editCheatmealButton.Location = new Point(509, 478);
            editCheatmealButton.Name = "editCheatmealButton";
            editCheatmealButton.Size = new Size(130, 40);
            editCheatmealButton.TabIndex = 10;
            editCheatmealButton.Text = "Edit";
            editCheatmealButton.UseVisualStyleBackColor = true;
            editCheatmealButton.Click += editCheatmealButton_Click;
            // 
            // AddCheatmealForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(889, 548);
            Controls.Add(deleteCheatmealButton);
            Controls.Add(editCheatmealButton);
            Controls.Add(cheatmealAddGroupBox);
            Controls.Add(cheatmealListView);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AddCheatmealForm";
            Text = "Add Cheatmeal";
            Load += AddCheatmealForm_Load;
            cheatmealAddGroupBox.ResumeLayout(false);
            cheatmealAddGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)caloriesGainRateNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView cheatmealListView;
        private ColumnHeader idHeader;
        private ColumnHeader nameHeader;
        private ColumnHeader caloryHeader;
        private GroupBox cheatmealAddGroupBox;
        private TextBox hiddenCheatmealIDText;
        private Label caloriesSubLabel;
        private Button saveCheatmealButton;
        private Label caloriesGainRateLabel;
        private NumericUpDown caloriesGainRateNumeric;
        private Label cheatmealNameLabel;
        private TextBox cheatmealNameText;
        private Button deleteCheatmealButton;
        private Button editCheatmealButton;
    }
}