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
            this.lb_lenghtOfLunchBreak = new System.Windows.Forms.Label();
            this.lb_otherBreakLength = new System.Windows.Forms.Label();
            this.lb_endWork = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.dt_startTime = new System.Windows.Forms.DateTimePicker();
            this.dt_endTime = new System.Windows.Forms.DateTimePicker();
            this.ud_lunchBreak = new System.Windows.Forms.NumericUpDown();
            this.ud_otherBreaks = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ud_lunchBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_otherBreaks)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_startWork
            // 
            this.lb_startWork.AutoSize = true;
            this.lb_startWork.Location = new System.Drawing.Point(84, 30);
            this.lb_startWork.Name = "lb_startWork";
            this.lb_startWork.Size = new System.Drawing.Size(110, 17);
            this.lb_startWork.TabIndex = 2;
            this.lb_startWork.Text = "Started working:";
            // 
            // lb_lenghtOfLunchBreak
            // 
            this.lb_lenghtOfLunchBreak.AutoSize = true;
            this.lb_lenghtOfLunchBreak.Location = new System.Drawing.Point(43, 80);
            this.lb_lenghtOfLunchBreak.Name = "lb_lenghtOfLunchBreak";
            this.lb_lenghtOfLunchBreak.Size = new System.Drawing.Size(151, 17);
            this.lb_lenghtOfLunchBreak.TabIndex = 3;
            this.lb_lenghtOfLunchBreak.Text = "Length of Lunchbreak:";
            // 
            // lb_otherBreakLength
            // 
            this.lb_otherBreakLength.AutoSize = true;
            this.lb_otherBreakLength.Location = new System.Drawing.Point(34, 120);
            this.lb_otherBreakLength.Name = "lb_otherBreakLength";
            this.lb_otherBreakLength.Size = new System.Drawing.Size(160, 17);
            this.lb_otherBreakLength.TabIndex = 4;
            this.lb_otherBreakLength.Text = "Length of Other Breaks:";
            // 
            // lb_endWork
            // 
            this.lb_endWork.AutoSize = true;
            this.lb_endWork.Location = new System.Drawing.Point(89, 170);
            this.lb_endWork.Name = "lb_endWork";
            this.lb_endWork.Size = new System.Drawing.Size(105, 17);
            this.lb_endWork.TabIndex = 5;
            this.lb_endWork.Text = "Ended working:";
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(25, 224);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(153, 35);
            this.bt_submit.TabIndex = 10;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(184, 224);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(153, 35);
            this.bt_clear.TabIndex = 11;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(343, 224);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(153, 35);
            this.bt_exit.TabIndex = 12;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // dt_startTime
            // 
            this.dt_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_startTime.Location = new System.Drawing.Point(230, 25);
            this.dt_startTime.Name = "dt_startTime";
            this.dt_startTime.Size = new System.Drawing.Size(130, 22);
            this.dt_startTime.TabIndex = 13;
            // 
            // dt_endTime
            // 
            this.dt_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_endTime.Location = new System.Drawing.Point(230, 165);
            this.dt_endTime.Name = "dt_endTime";
            this.dt_endTime.Size = new System.Drawing.Size(130, 22);
            this.dt_endTime.TabIndex = 14;
            // 
            // ud_lunchBreak
            // 
            this.ud_lunchBreak.Location = new System.Drawing.Point(230, 78);
            this.ud_lunchBreak.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.ud_lunchBreak.Name = "ud_lunchBreak";
            this.ud_lunchBreak.Size = new System.Drawing.Size(130, 22);
            this.ud_lunchBreak.TabIndex = 17;
            // 
            // ud_otherBreaks
            // 
            this.ud_otherBreaks.Location = new System.Drawing.Point(230, 118);
            this.ud_otherBreaks.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.ud_otherBreaks.Name = "ud_otherBreaks";
            this.ud_otherBreaks.Size = new System.Drawing.Size(130, 22);
            this.ud_otherBreaks.TabIndex = 18;
            // 
            // EmployeeAddAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 278);
            this.Controls.Add(this.ud_otherBreaks);
            this.Controls.Add(this.ud_lunchBreak);
            this.Controls.Add(this.dt_endTime);
            this.Controls.Add(this.dt_startTime);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.lb_endWork);
            this.Controls.Add(this.lb_otherBreakLength);
            this.Controls.Add(this.lb_lenghtOfLunchBreak);
            this.Controls.Add(this.lb_startWork);
            this.Name = "EmployeeAddAttendanceForm";
            this.Text = "Add Attendance";
            this.Load += new System.EventHandler(this.EmployeeAddAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ud_lunchBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_otherBreaks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_startWork;
        private System.Windows.Forms.Label lb_lenghtOfLunchBreak;
        private System.Windows.Forms.Label lb_otherBreakLength;
        private System.Windows.Forms.Label lb_endWork;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.DateTimePicker dt_startTime;
        private System.Windows.Forms.DateTimePicker dt_endTime;
        private System.Windows.Forms.NumericUpDown ud_lunchBreak;
        private System.Windows.Forms.NumericUpDown ud_otherBreaks;
    }
}