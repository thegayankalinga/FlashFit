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
            label1 = new Label();
            addWorkoutFormButton = new Button();
            listView1 = new ListView();
            id = new ColumnHeader();
            name = new ColumnHeader();
            type = new ColumnHeader();
            calories = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(23, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 21);
            label1.TabIndex = 0;
            label1.Text = "Workout User Control Form";
            label1.Click += label1_Click;
            // 
            // addWorkoutFormButton
            // 
            addWorkoutFormButton.FlatStyle = FlatStyle.Flat;
            addWorkoutFormButton.Location = new Point(23, 75);
            addWorkoutFormButton.Name = "addWorkoutFormButton";
            addWorkoutFormButton.Size = new Size(114, 47);
            addWorkoutFormButton.TabIndex = 1;
            addWorkoutFormButton.Text = "Add Workout";
            addWorkoutFormButton.UseVisualStyleBackColor = true;
            addWorkoutFormButton.Click += addWorkoutFormButton_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, name, type, calories });
            listView1.Location = new Point(563, 54);
            listView1.Name = "listView1";
            listView1.Size = new Size(357, 399);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // id
            // 
            id.Width = 50;
            // 
            // name
            // 
            name.Width = 100;
            // 
            // type
            // 
            type.Width = 100;
            // 
            // calories
            // 
            calories.Width = 100;
            // 
            // WorkoutUserControlForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(listView1);
            Controls.Add(addWorkoutFormButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.HighlightText;
            Margin = new Padding(4);
            Name = "WorkoutUserControlForm";
            Size = new Size(970, 528);
            Enter += WorkoutUserControlForm_Enter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addWorkoutFormButton;
        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader type;
        private ColumnHeader calories;
    }
}
