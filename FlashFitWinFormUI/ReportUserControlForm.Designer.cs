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
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            date = new ColumnHeader();
            Name = new ColumnHeader();
            weight = new ColumnHeader();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(162, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 29);
            comboBox1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(46, 51, 73);
            listView1.Columns.AddRange(new ColumnHeader[] { date, Name, weight });
            listView1.Location = new Point(570, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(417, 438);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 2;
            label1.Text = "Report Type";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 29);
            dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 103);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 2;
            label2.Text = "From Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 162);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "To Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(165, 154);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(272, 29);
            dateTimePicker2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 270);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 2;
            label4.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 329);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 2;
            label5.Text = "label1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 388);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 2;
            label6.Text = "label1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 433);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 2;
            label7.Text = "label1";
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 150;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 150;
            // 
            // weight
            // 
            weight.Text = "Weight";
            weight.TextAlign = HorizontalAlignment.Right;
            weight.Width = 100;
            // 
            // ReportUserControlForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(dateTimePicker2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ReportUserControlForm";
            Size = new Size(1042, 528);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ListView listView1;
        private ColumnHeader date;
        private ColumnHeader Name;
        private ColumnHeader weight;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
