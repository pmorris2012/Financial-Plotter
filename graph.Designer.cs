namespace GAD_HW2
{
    partial class graph
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.startDay = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.startMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startYear = new System.Windows.Forms.NumericUpDown();
            this.endYear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.endMonth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endDay = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_HiLoOpenClose = new System.Windows.Forms.Button();
            this.button_CandleSticks = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.avg1 = new System.Windows.Forms.CheckBox();
            this.avg3 = new System.Windows.Forms.CheckBox();
            this.avg2 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.avg1Num = new System.Windows.Forms.NumericUpDown();
            this.avg2Num = new System.Windows.Forms.NumericUpDown();
            this.avg3Num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.startDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avg1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avg2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avg3Num)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 2);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 589);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Month";
            // 
            // startDay
            // 
            this.startDay.Location = new System.Drawing.Point(138, 609);
            this.startDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.startDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startDay.Name = "startDay";
            this.startDay.Size = new System.Drawing.Size(54, 22);
            this.startDay.TabIndex = 11;
            this.startDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 589);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Day";
            // 
            // startMonth
            // 
            this.startMonth.FormattingEnabled = true;
            this.startMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.startMonth.Location = new System.Drawing.Point(11, 609);
            this.startMonth.Name = "startMonth";
            this.startMonth.Size = new System.Drawing.Size(121, 24);
            this.startMonth.TabIndex = 13;
            this.startMonth.SelectedIndexChanged += new System.EventHandler(this.MonthYear_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Year";
            // 
            // startYear
            // 
            this.startYear.Location = new System.Drawing.Point(198, 609);
            this.startYear.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.startYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startYear.Name = "startYear";
            this.startYear.Size = new System.Drawing.Size(80, 22);
            this.startYear.TabIndex = 15;
            this.startYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startYear.ValueChanged += new System.EventHandler(this.MonthYear_SelectedIndexChanged);
            // 
            // endYear
            // 
            this.endYear.Location = new System.Drawing.Point(514, 609);
            this.endYear.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.endYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endYear.Name = "endYear";
            this.endYear.Size = new System.Drawing.Size(80, 22);
            this.endYear.TabIndex = 21;
            this.endYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endYear.ValueChanged += new System.EventHandler(this.MonthYear_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Year";
            // 
            // endMonth
            // 
            this.endMonth.FormattingEnabled = true;
            this.endMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.endMonth.Location = new System.Drawing.Point(327, 609);
            this.endMonth.Name = "endMonth";
            this.endMonth.Size = new System.Drawing.Size(121, 24);
            this.endMonth.TabIndex = 19;
            this.endMonth.SelectedIndexChanged += new System.EventHandler(this.MonthYear_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Day";
            // 
            // endDay
            // 
            this.endDay.Location = new System.Drawing.Point(454, 609);
            this.endDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.endDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endDay.Name = "endDay";
            this.endDay.Size = new System.Drawing.Size(54, 22);
            this.endDay.TabIndex = 17;
            this.endDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 589);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Month";
            // 
            // button_Close
            // 
            this.button_Close.Enabled = false;
            this.button_Close.Location = new System.Drawing.Point(424, 660);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(184, 23);
            this.button_Close.TabIndex = 22;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_HiLoOpenClose
            // 
            this.button_HiLoOpenClose.Location = new System.Drawing.Point(424, 689);
            this.button_HiLoOpenClose.Name = "button_HiLoOpenClose";
            this.button_HiLoOpenClose.Size = new System.Drawing.Size(184, 23);
            this.button_HiLoOpenClose.TabIndex = 23;
            this.button_HiLoOpenClose.Text = "High Low Open Close";
            this.button_HiLoOpenClose.UseVisualStyleBackColor = true;
            this.button_HiLoOpenClose.Click += new System.EventHandler(this.button_HiLoOpenClose_Click);
            // 
            // button_CandleSticks
            // 
            this.button_CandleSticks.Location = new System.Drawing.Point(424, 718);
            this.button_CandleSticks.Name = "button_CandleSticks";
            this.button_CandleSticks.Size = new System.Drawing.Size(184, 23);
            this.button_CandleSticks.TabIndex = 24;
            this.button_CandleSticks.Text = "Candle Sticks";
            this.button_CandleSticks.UseVisualStyleBackColor = true;
            this.button_CandleSticks.Click += new System.EventHandler(this.button_CandleSticks_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 692);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Formats:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 692);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Moving Avgs";
            // 
            // avg1
            // 
            this.avg1.AutoSize = true;
            this.avg1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avg1.ForeColor = System.Drawing.Color.Green;
            this.avg1.Location = new System.Drawing.Point(102, 660);
            this.avg1.Name = "avg1";
            this.avg1.Size = new System.Drawing.Size(46, 21);
            this.avg1.TabIndex = 27;
            this.avg1.Text = "#1";
            this.avg1.UseVisualStyleBackColor = true;
            this.avg1.CheckedChanged += new System.EventHandler(this.LoadGraph);
            // 
            // avg3
            // 
            this.avg3.AutoSize = true;
            this.avg3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avg3.ForeColor = System.Drawing.Color.Purple;
            this.avg3.Location = new System.Drawing.Point(102, 718);
            this.avg3.Name = "avg3";
            this.avg3.Size = new System.Drawing.Size(46, 21);
            this.avg3.TabIndex = 28;
            this.avg3.Text = "#3";
            this.avg3.UseVisualStyleBackColor = true;
            this.avg3.CheckedChanged += new System.EventHandler(this.LoadGraph);
            // 
            // avg2
            // 
            this.avg2.AutoSize = true;
            this.avg2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.avg2.ForeColor = System.Drawing.Color.Orange;
            this.avg2.Location = new System.Drawing.Point(102, 689);
            this.avg2.Name = "avg2";
            this.avg2.Size = new System.Drawing.Size(46, 21);
            this.avg2.TabIndex = 29;
            this.avg2.Text = "#2";
            this.avg2.UseVisualStyleBackColor = true;
            this.avg2.CheckedChanged += new System.EventHandler(this.LoadGraph);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(176, 643);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "# of Days";
            // 
            // avg1Num
            // 
            this.avg1Num.Location = new System.Drawing.Point(158, 660);
            this.avg1Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.avg1Num.Name = "avg1Num";
            this.avg1Num.Size = new System.Drawing.Size(120, 22);
            this.avg1Num.TabIndex = 31;
            this.avg1Num.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.avg1Num.ValueChanged += new System.EventHandler(this.avg1Num_ValueChanged);
            // 
            // avg2Num
            // 
            this.avg2Num.Location = new System.Drawing.Point(158, 689);
            this.avg2Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.avg2Num.Name = "avg2Num";
            this.avg2Num.Size = new System.Drawing.Size(120, 22);
            this.avg2Num.TabIndex = 32;
            this.avg2Num.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.avg2Num.ValueChanged += new System.EventHandler(this.avg2Num_ValueChanged);
            // 
            // avg3Num
            // 
            this.avg3Num.Location = new System.Drawing.Point(158, 718);
            this.avg3Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.avg3Num.Name = "avg3Num";
            this.avg3Num.Size = new System.Drawing.Size(120, 22);
            this.avg3Num.TabIndex = 33;
            this.avg3Num.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.avg3Num.ValueChanged += new System.EventHandler(this.avg3Num_ValueChanged);
            // 
            // graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 753);
            this.Controls.Add(this.avg3Num);
            this.Controls.Add(this.avg2Num);
            this.Controls.Add(this.avg1Num);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.avg2);
            this.Controls.Add(this.avg3);
            this.Controls.Add(this.avg1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_CandleSticks);
            this.Controls.Add(this.button_HiLoOpenClose);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.endYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startMonth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.startDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "graph";
            this.Text = "graph";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.graph_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.startDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avg1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avg2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avg3Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown startDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox startMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown startYear;
        private System.Windows.Forms.NumericUpDown endYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox endMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown endDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_HiLoOpenClose;
        private System.Windows.Forms.Button button_CandleSticks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox avg1;
        private System.Windows.Forms.CheckBox avg3;
        private System.Windows.Forms.CheckBox avg2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown avg1Num;
        private System.Windows.Forms.NumericUpDown avg2Num;
        private System.Windows.Forms.NumericUpDown avg3Num;
    }
}