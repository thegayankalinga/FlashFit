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
            label1 = new Label();
            addCheatMealButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 149);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Cheat Meal Form";
            // 
            // addCheatMealButton
            // 
            addCheatMealButton.Location = new Point(61, 254);
            addCheatMealButton.Name = "addCheatMealButton";
            addCheatMealButton.Size = new Size(134, 30);
            addCheatMealButton.TabIndex = 1;
            addCheatMealButton.Text = "Add New Cheatmeal";
            addCheatMealButton.UseVisualStyleBackColor = true;
            addCheatMealButton.Click += addCheatMealButton_Click;
            // 
            // CheatmealUserControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(addCheatMealButton);
            Controls.Add(label1);
            Name = "CheatmealUserControlForm";
            Size = new Size(768, 542);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addCheatMealButton;
    }
}
