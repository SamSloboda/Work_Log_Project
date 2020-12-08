namespace Work_Log_Project
{
    partial class EmployeeAddAttendanceForm
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
            this.lb_startWork = new System.Windows.Forms.Label();
            this.lb_otherBreakLength = new System.Windows.Forms.Label();
            this.lb_endWork = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.dt_startTime = new System.Windows.Forms.DateTimePicker();
            this.dt_endTime = new System.Windows.Forms.DateTimePicker();
            this.ud_otherBreaks = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_close = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lb_lenghtOfLunchBreak = new System.Windows.Forms.Label();
            this.ud_lunchBreak = new System.Windows.Forms.NumericUpDown();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ud_otherBreaks)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_lunchBreak)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_startWork
            // 
            this.lb_startWork.AutoSize = true;
            this.lb_startWork.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lb_startWork.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_startWork.Location = new System.Drawing.Point(11, 13);
            this.lb_startWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_startWork.Name = "lb_startWork";
            this.lb_startWork.Size = new System.Drawing.Size(184, 27);
            this.lb_startWork.TabIndex = 2;
            this.lb_startWork.Text = "~Started working~";
            // 
            // lb_otherBreakLength
            // 
            this.lb_otherBreakLength.AutoSize = true;
            this.lb_otherBreakLength.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lb_otherBreakLength.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_otherBreakLength.Location = new System.Drawing.Point(19, 11);
            this.lb_otherBreakLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_otherBreakLength.Name = "lb_otherBreakLength";
            this.lb_otherBreakLength.Size = new System.Drawing.Size(250, 27);
            this.lb_otherBreakLength.TabIndex = 4;
            this.lb_otherBreakLength.Text = "~Length of Other Breaks~";
            // 
            // lb_endWork
            // 
            this.lb_endWork.AutoSize = true;
            this.lb_endWork.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lb_endWork.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_endWork.Location = new System.Drawing.Point(22, 9);
            this.lb_endWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_endWork.Name = "lb_endWork";
            this.lb_endWork.Size = new System.Drawing.Size(172, 27);
            this.lb_endWork.TabIndex = 5;
            this.lb_endWork.Text = "~Ended working~";
            // 
            // bt_submit
            // 
            this.bt_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_submit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.bt_submit.ForeColor = System.Drawing.Color.White;
            this.bt_submit.Location = new System.Drawing.Point(2, 2);
            this.bt_submit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(160, 40);
            this.bt_submit.TabIndex = 10;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_clear.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.bt_clear.ForeColor = System.Drawing.Color.White;
            this.bt_clear.Location = new System.Drawing.Point(2, 2);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(2);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(160, 40);
            this.bt_clear.TabIndex = 11;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // bt_exit
            // 
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_exit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.bt_exit.ForeColor = System.Drawing.Color.White;
            this.bt_exit.Location = new System.Drawing.Point(2, 2);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(160, 40);
            this.bt_exit.TabIndex = 12;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // dt_startTime
            // 
            this.dt_startTime.CalendarFont = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.dt_startTime.CalendarTitleForeColor = System.Drawing.Color.Crimson;
            this.dt_startTime.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.dt_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_startTime.Location = new System.Drawing.Point(389, 8);
            this.dt_startTime.Margin = new System.Windows.Forms.Padding(2);
            this.dt_startTime.Name = "dt_startTime";
            this.dt_startTime.Size = new System.Drawing.Size(154, 32);
            this.dt_startTime.TabIndex = 13;
            // 
            // dt_endTime
            // 
            this.dt_endTime.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dt_endTime.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dt_endTime.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.dt_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_endTime.Location = new System.Drawing.Point(385, 9);
            this.dt_endTime.Margin = new System.Windows.Forms.Padding(2);
            this.dt_endTime.Name = "dt_endTime";
            this.dt_endTime.Size = new System.Drawing.Size(154, 32);
            this.dt_endTime.TabIndex = 14;
            // 
            // ud_otherBreaks
            // 
            this.ud_otherBreaks.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.ud_otherBreaks.Location = new System.Drawing.Point(385, 9);
            this.ud_otherBreaks.Margin = new System.Windows.Forms.Padding(2);
            this.ud_otherBreaks.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.ud_otherBreaks.Name = "ud_otherBreaks";
            this.ud_otherBreaks.Size = new System.Drawing.Size(154, 32);
            this.ud_otherBreaks.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel3.Location = new System.Drawing.Point(12, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 50);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.bt_submit);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 44);
            this.panel4.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel1.Location = new System.Drawing.Point(199, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 50);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.bt_clear);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 44);
            this.panel2.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel5.Location = new System.Drawing.Point(386, 415);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 50);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel6.Controls.Add(this.bt_exit);
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(164, 44);
            this.panel6.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel7.Controls.Add(this.lb_startWork);
            this.panel7.Controls.Add(this.dt_startTime);
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.panel7.Location = new System.Drawing.Point(-4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(579, 47);
            this.panel7.TabIndex = 22;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel9.Controls.Add(this.lb_otherBreakLength);
            this.panel9.Controls.Add(this.ud_otherBreaks);
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.panel9.Location = new System.Drawing.Point(0, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(575, 47);
            this.panel9.TabIndex = 24;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Crimson;
            this.panel11.Controls.Add(this.panel7);
            this.panel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel11.Location = new System.Drawing.Point(1, 69);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(575, 54);
            this.panel11.TabIndex = 26;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel10.Controls.Add(this.dt_endTime);
            this.panel10.Controls.Add(this.lb_endWork);
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.panel10.Location = new System.Drawing.Point(0, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(575, 47);
            this.panel10.TabIndex = 29;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, -2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(572, 31);
            this.flowLayoutPanel1.TabIndex = 31;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            // 
            // lb_close
            // 
            this.lb_close.AutoSize = true;
            this.lb_close.BackColor = System.Drawing.Color.Transparent;
            this.lb_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lb_close.ForeColor = System.Drawing.Color.Crimson;
            this.lb_close.Location = new System.Drawing.Point(526, 9);
            this.lb_close.Name = "lb_close";
            this.lb_close.Size = new System.Drawing.Size(30, 29);
            this.lb_close.TabIndex = 32;
            this.lb_close.Text = "X";
            this.lb_close.Click += new System.EventHandler(this.lb_close_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel8.Controls.Add(this.lb_lenghtOfLunchBreak);
            this.panel8.Controls.Add(this.ud_lunchBreak);
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.panel8.Location = new System.Drawing.Point(0, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(575, 47);
            this.panel8.TabIndex = 23;
            // 
            // lb_lenghtOfLunchBreak
            // 
            this.lb_lenghtOfLunchBreak.AutoSize = true;
            this.lb_lenghtOfLunchBreak.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lb_lenghtOfLunchBreak.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_lenghtOfLunchBreak.Location = new System.Drawing.Point(19, 9);
            this.lb_lenghtOfLunchBreak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_lenghtOfLunchBreak.Name = "lb_lenghtOfLunchBreak";
            this.lb_lenghtOfLunchBreak.Size = new System.Drawing.Size(236, 27);
            this.lb_lenghtOfLunchBreak.TabIndex = 3;
            this.lb_lenghtOfLunchBreak.Text = "~Length of Lunchbreak~";
            // 
            // ud_lunchBreak
            // 
            this.ud_lunchBreak.BackColor = System.Drawing.SystemColors.Window;
            this.ud_lunchBreak.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.ud_lunchBreak.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ud_lunchBreak.Location = new System.Drawing.Point(385, 7);
            this.ud_lunchBreak.Margin = new System.Windows.Forms.Padding(2);
            this.ud_lunchBreak.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.ud_lunchBreak.Name = "ud_lunchBreak";
            this.ud_lunchBreak.Size = new System.Drawing.Size(154, 32);
            this.ud_lunchBreak.TabIndex = 17;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Crimson;
            this.panel12.Controls.Add(this.panel8);
            this.panel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel12.Location = new System.Drawing.Point(1, 152);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(575, 54);
            this.panel12.TabIndex = 33;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Crimson;
            this.panel13.Controls.Add(this.panel9);
            this.panel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel13.Location = new System.Drawing.Point(1, 234);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(575, 54);
            this.panel13.TabIndex = 34;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Crimson;
            this.panel14.Controls.Add(this.panel10);
            this.panel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel14.Location = new System.Drawing.Point(1, 317);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(575, 54);
            this.panel14.TabIndex = 35;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Crimson;
            this.panel15.Location = new System.Drawing.Point(-3, 495);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(576, 10);
            this.panel15.TabIndex = 36;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel16.Location = new System.Drawing.Point(-3, 485);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(576, 17);
            this.panel16.TabIndex = 37;
            // 
            // EmployeeAddAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(568, 507);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.lb_close);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeAddAttendanceForm";
            this.Text = "Add Attendance";
            this.Load += new System.EventHandler(this.EmployeeAddAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ud_otherBreaks)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_lunchBreak)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_startWork;
        private System.Windows.Forms.Label lb_otherBreakLength;
        private System.Windows.Forms.Label lb_endWork;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.DateTimePicker dt_startTime;
        private System.Windows.Forms.DateTimePicker dt_endTime;
        private System.Windows.Forms.NumericUpDown ud_otherBreaks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_close;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lb_lenghtOfLunchBreak;
        private System.Windows.Forms.NumericUpDown ud_lunchBreak;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
    }
}