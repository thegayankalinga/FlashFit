namespace FlashFitWinFormUI
{
    partial class PredictionUserControlForm
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
            predictedToDateCalender = new MonthCalendar();
            selectFutureDateLabel = new Label();
            predictedWeigtText = new TextBox();
            predictedWeightLabel = new Label();
            predictedBMIText = new TextBox();
            predictedBMILable = new Label();
            placeholderForHealthStatusLabel = new Label();
            groupBox1 = new GroupBox();
            calculateButton = new Button();
            plcSuggestionLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // predictedToDateCalender
            // 
            predictedToDateCalender.Location = new Point(12, 64);
            predictedToDateCalender.MaxSelectionCount = 1;
            predictedToDateCalender.Name = "predictedToDateCalender";
            predictedToDateCalender.TabIndex = 0;
            // 
            // selectFutureDateLabel
            // 
            selectFutureDateLabel.AutoSize = true;
            selectFutureDateLabel.ForeColor = SystemColors.HighlightText;
            selectFutureDateLabel.Location = new Point(12, 34);
            selectFutureDateLabel.Name = "selectFutureDateLabel";
            selectFutureDateLabel.Size = new Size(148, 21);
            selectFutureDateLabel.TabIndex = 1;
            selectFutureDateLabel.Text = "Select a Future Date";
            // 
            // predictedWeigtText
            // 
            predictedWeigtText.BackColor = SystemColors.InactiveBorder;
            predictedWeigtText.Enabled = false;
            predictedWeigtText.ForeColor = SystemColors.ControlText;
            predictedWeigtText.Location = new Point(234, 320);
            predictedWeigtText.Name = "predictedWeigtText";
            predictedWeigtText.Size = new Size(136, 29);
            predictedWeigtText.TabIndex = 2;
            predictedWeigtText.TextAlign = HorizontalAlignment.Right;
            // 
            // predictedWeightLabel
            // 
            predictedWeightLabel.AutoSize = true;
            predictedWeightLabel.ForeColor = SystemColors.HighlightText;
            predictedWeightLabel.Location = new Point(23, 323);
            predictedWeightLabel.Name = "predictedWeightLabel";
            predictedWeightLabel.Size = new Size(128, 21);
            predictedWeightLabel.TabIndex = 3;
            predictedWeightLabel.Text = "Predicted Weight";
            // 
            // predictedBMIText
            // 
            predictedBMIText.BackColor = SystemColors.InactiveBorder;
            predictedBMIText.Enabled = false;
            predictedBMIText.ForeColor = SystemColors.ControlText;
            predictedBMIText.Location = new Point(234, 378);
            predictedBMIText.Name = "predictedBMIText";
            predictedBMIText.Size = new Size(136, 29);
            predictedBMIText.TabIndex = 2;
            predictedBMIText.TextAlign = HorizontalAlignment.Right;
            // 
            // predictedBMILable
            // 
            predictedBMILable.AutoSize = true;
            predictedBMILable.ForeColor = SystemColors.HighlightText;
            predictedBMILable.Location = new Point(23, 381);
            predictedBMILable.Name = "predictedBMILable";
            predictedBMILable.Size = new Size(106, 21);
            predictedBMILable.TabIndex = 3;
            predictedBMILable.Text = "Predicted BMI";
            // 
            // placeholderForHealthStatusLabel
            // 
            placeholderForHealthStatusLabel.AutoSize = true;
            placeholderForHealthStatusLabel.ForeColor = SystemColors.HighlightText;
            placeholderForHealthStatusLabel.Location = new Point(23, 429);
            placeholderForHealthStatusLabel.Name = "placeholderForHealthStatusLabel";
            placeholderForHealthStatusLabel.Size = new Size(298, 21);
            placeholderForHealthStatusLabel.TabIndex = 3;
            placeholderForHealthStatusLabel.Text = "<placeholder for predicted health status>";
            placeholderForHealthStatusLabel.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(calculateButton);
            groupBox1.Controls.Add(predictedBMIText);
            groupBox1.Controls.Add(placeholderForHealthStatusLabel);
            groupBox1.Controls.Add(predictedWeigtText);
            groupBox1.Controls.Add(predictedToDateCalender);
            groupBox1.Controls.Add(predictedBMILable);
            groupBox1.Controls.Add(selectFutureDateLabel);
            groupBox1.Controls.Add(predictedWeightLabel);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(25, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 473);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Health Status Prediction";
            // 
            // calculateButton
            // 
            calculateButton.FlatStyle = FlatStyle.Flat;
            calculateButton.Location = new Point(139, 247);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(100, 32);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // plcSuggestionLabel
            // 
            plcSuggestionLabel.AutoSize = true;
            plcSuggestionLabel.ForeColor = SystemColors.Info;
            plcSuggestionLabel.Location = new Point(450, 60);
            plcSuggestionLabel.Name = "plcSuggestionLabel";
            plcSuggestionLabel.Size = new Size(242, 21);
            plcSuggestionLabel.TabIndex = 5;
            plcSuggestionLabel.Text = "<placeholder for suggestiontext>";
            plcSuggestionLabel.Visible = false;
            // 
            // PredictionUserControlForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(plcSuggestionLabel);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "PredictionUserControlForm";
            Size = new Size(1042, 528);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar predictedToDateCalender;
        private Label selectFutureDateLabel;
        private TextBox predictedWeigtText;
        private Label predictedWeightLabel;
        private TextBox predictedBMIText;
        private Label predictedBMILable;
        private Label placeholderForHealthStatusLabel;
        private GroupBox groupBox1;
        private Button calculateButton;
        private Label plcSuggestionLabel;
    }
}
