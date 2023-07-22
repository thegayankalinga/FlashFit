namespace FlashFitWinFormUI
{
    partial class ReportUserControlForm
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
            reportTypeComboBox = new ComboBox();
            reportListView = new ListView();
            date = new ColumnHeader();
            typeName = new ColumnHeader();
            weight = new ColumnHeader();
            label1 = new Label();
            fromDatePicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            toDatePicker = new DateTimePicker();
            weightPcl = new Label();
            bmiPlc = new Label();
            healthStatusPlc = new Label();
            groupBox1 = new GroupBox();
            getAllRecordButton = new Button();
            filterByDateButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            namePlac = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // reportTypeComboBox
            // 
            reportTypeComboBox.FormattingEnabled = true;
            reportTypeComboBox.Items.AddRange(new object[] { "Cheatmeal", "Workout" });
            reportTypeComboBox.Location = new Point(138, 28);
            reportTypeComboBox.Name = "reportTypeComboBox";
            reportTypeComboBox.Size = new Size(203, 29);
            reportTypeComboBox.TabIndex = 0;
            // 
            // reportListView
            // 
            reportListView.BackColor = Color.FromArgb(46, 51, 73);
            reportListView.Columns.AddRange(new ColumnHeader[] { date, typeName, weight });
            reportListView.ForeColor = SystemColors.Window;
            reportListView.Location = new Point(570, 38);
            reportListView.Name = "reportListView";
            reportListView.Size = new Size(417, 463);
            reportListView.TabIndex = 1;
            reportListView.UseCompatibleStateImageBehavior = false;
            reportListView.View = View.Details;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 150;
            // 
            // typeName
            // 
            typeName.Text = "Type Name";
            typeName.Width = 150;
            // 
            // weight
            // 
            weight.Text = "Weight";
            weight.TextAlign = HorizontalAlignment.Right;
            weight.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 2;
            label1.Text = "Report Type";
            // 
            // fromDatePicker
            // 
            fromDatePicker.Location = new Point(138, 134);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(272, 29);
            fromDatePicker.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 140);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 2;
            label2.Text = "From Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 196);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "To Date";
            // 
            // toDatePicker
            // 
            toDatePicker.Location = new Point(138, 190);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(272, 29);
            toDatePicker.TabIndex = 3;
            // 
            // weightPcl
            // 
            weightPcl.AutoSize = true;
            weightPcl.Location = new Point(138, 332);
            weightPcl.Name = "weightPcl";
            weightPcl.Size = new Size(52, 21);
            weightPcl.TabIndex = 2;
            weightPcl.Text = "label1";
            // 
            // bmiPlc
            // 
            bmiPlc.AutoSize = true;
            bmiPlc.Location = new Point(138, 371);
            bmiPlc.Name = "bmiPlc";
            bmiPlc.Size = new Size(52, 21);
            bmiPlc.TabIndex = 2;
            bmiPlc.Text = "label1";
            // 
            // healthStatusPlc
            // 
            healthStatusPlc.AutoSize = true;
            healthStatusPlc.Location = new Point(138, 416);
            healthStatusPlc.Name = "healthStatusPlc";
            healthStatusPlc.Size = new Size(52, 21);
            healthStatusPlc.TabIndex = 2;
            healthStatusPlc.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(getAllRecordButton);
            groupBox1.Controls.Add(filterByDateButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(toDatePicker);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(fromDatePicker);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(healthStatusPlc);
            groupBox1.Controls.Add(reportTypeComboBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(weightPcl);
            groupBox1.Controls.Add(bmiPlc);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(27, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 463);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // getAllRecordButton
            // 
            getAllRecordButton.FlatStyle = FlatStyle.Flat;
            getAllRecordButton.Location = new Point(138, 74);
            getAllRecordButton.Name = "getAllRecordButton";
            getAllRecordButton.Size = new Size(136, 39);
            getAllRecordButton.TabIndex = 5;
            getAllRecordButton.Text = "Get All";
            getAllRecordButton.UseVisualStyleBackColor = true;
            getAllRecordButton.Click += getAllRecordButton_Click;
            // 
            // filterByDateButton
            // 
            filterByDateButton.FlatStyle = FlatStyle.Flat;
            filterByDateButton.Location = new Point(138, 246);
            filterByDateButton.Name = "filterByDateButton";
            filterByDateButton.Size = new Size(136, 39);
            filterByDateButton.TabIndex = 5;
            filterByDateButton.Text = "Filter By Date";
            filterByDateButton.UseVisualStyleBackColor = true;
            filterByDateButton.Click += filterByDateButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 416);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 2;
            label6.Text = "Overall Health";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 332);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 2;
            label5.Text = "Weight in KG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 371);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 2;
            label4.Text = "BMI";
            // 
            // namePlac
            // 
            namePlac.AutoSize = true;
            namePlac.ForeColor = SystemColors.Info;
            namePlac.Location = new Point(27, 14);
            namePlac.Name = "namePlac";
            namePlac.Size = new Size(52, 21);
            namePlac.TabIndex = 2;
            namePlac.Text = "label1";
            // 
            // ReportUserControlForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(reportListView);
            Controls.Add(groupBox1);
            Controls.Add(namePlac);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ReportUserControlForm";
            Size = new Size(1042, 528);
            Load += ReportUserControlForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox reportTypeComboBox;
        private ListView reportListView;
        private ColumnHeader date;
        private ColumnHeader typeName;
        private ColumnHeader weight;
        private Label label1;
        private DateTimePicker fromDatePicker;
        private Label label2;
        private Label label3;
        private DateTimePicker toDatePicker;
        private Label weightPcl;
        private Label bmiPlc;
        private Label healthStatusPlc;
        private GroupBox groupBox1;
        private Button filterByDateButton;
        private Button getAllRecordButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label namePlac;
    }
}
