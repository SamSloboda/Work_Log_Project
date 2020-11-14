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
            this.dtp_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lb_chooseDate = new System.Windows.Forms.Label();
            this.lb_startWork = new System.Windows.Forms.Label();
            this.lb_lenghtOfLunchBreak = new System.Windows.Forms.Label();
            this.lb_otherBreakLength = new System.Windows.Forms.Label();
            this.lb_endWork = new System.Windows.Forms.Label();
            this.tb_lenghtOfLunchBreak = new System.Windows.Forms.TextBox();
            this.tb_otherBreakLength = new System.Windows.Forms.TextBox();
            this.tb_startWork = new System.Windows.Forms.TextBox();
            this.tb_endWork = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_DateTimePicker
            // 
            this.dtp_DateTimePicker.Location = new System.Drawing.Point(230, 35);
            this.dtp_DateTimePicker.Name = "dtp_DateTimePicker";
            this.dtp_DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dtp_DateTimePicker.TabIndex = 0;
            // 
            // lb_chooseDate
            // 
            this.lb_chooseDate.AutoSize = true;
            this.lb_chooseDate.Location = new System.Drawing.Point(100, 40);
            this.lb_chooseDate.Name = "lb_chooseDate";
            this.lb_chooseDate.Size = new System.Drawing.Size(94, 17);
            this.lb_chooseDate.TabIndex = 1;
            this.lb_chooseDate.Text = "Choose Date:";
            // 
            // lb_startWork
            // 
            this.lb_startWork.AutoSize = true;
            this.lb_startWork.Location = new System.Drawing.Point(84, 90);
            this.lb_startWork.Name = "lb_startWork";
            this.lb_startWork.Size = new System.Drawing.Size(110, 17);
            this.lb_startWork.TabIndex = 2;
            this.lb_startWork.Text = "Started working:";
            // 
            // lb_lenghtOfLunchBreak
            // 
            this.lb_lenghtOfLunchBreak.AutoSize = true;
            this.lb_lenghtOfLunchBreak.Location = new System.Drawing.Point(43, 138);
            this.lb_lenghtOfLunchBreak.Name = "lb_lenghtOfLunchBreak";
            this.lb_lenghtOfLunchBreak.Size = new System.Drawing.Size(151, 17);
            this.lb_lenghtOfLunchBreak.TabIndex = 3;
            this.lb_lenghtOfLunchBreak.Text = "Length of Lunchbreak:";
            // 
            // lb_otherBreakLength
            // 
            this.lb_otherBreakLength.AutoSize = true;
            this.lb_otherBreakLength.Location = new System.Drawing.Point(34, 188);
            this.lb_otherBreakLength.Name = "lb_otherBreakLength";
            this.lb_otherBreakLength.Size = new System.Drawing.Size(160, 17);
            this.lb_otherBreakLength.TabIndex = 4;
            this.lb_otherBreakLength.Text = "Length of Other Breaks:";
            // 
            // lb_endWork
            // 
            this.lb_endWork.AutoSize = true;
            this.lb_endWork.Location = new System.Drawing.Point(89, 238);
            this.lb_endWork.Name = "lb_endWork";
            this.lb_endWork.Size = new System.Drawing.Size(105, 17);
            this.lb_endWork.TabIndex = 5;
            this.lb_endWork.Text = "Ended working:";
            // 
            // tb_lenghtOfLunchBreak
            // 
            this.tb_lenghtOfLunchBreak.Location = new System.Drawing.Point(230, 135);
            this.tb_lenghtOfLunchBreak.Name = "tb_lenghtOfLunchBreak";
            this.tb_lenghtOfLunchBreak.Size = new System.Drawing.Size(200, 22);
            this.tb_lenghtOfLunchBreak.TabIndex = 6;
            // 
            // tb_otherBreakLength
            // 
            this.tb_otherBreakLength.Location = new System.Drawing.Point(230, 185);
            this.tb_otherBreakLength.Name = "tb_otherBreakLength";
            this.tb_otherBreakLength.Size = new System.Drawing.Size(200, 22);
            this.tb_otherBreakLength.TabIndex = 7;
            // 
            // tb_startWork
            // 
            this.tb_startWork.Location = new System.Drawing.Point(230, 85);
            this.tb_startWork.Name = "tb_startWork";
            this.tb_startWork.Size = new System.Drawing.Size(200, 22);
            this.tb_startWork.TabIndex = 8;
            // 
            // tb_endWork
            // 
            this.tb_endWork.Location = new System.Drawing.Point(230, 235);
            this.tb_endWork.Name = "tb_endWork";
            this.tb_endWork.Size = new System.Drawing.Size(200, 22);
            this.tb_endWork.TabIndex = 9;
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(20, 300);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(153, 35);
            this.bt_submit.TabIndex = 10;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(180, 300);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(153, 35);
            this.bt_clear.TabIndex = 11;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(340, 300);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(153, 35);
            this.bt_exit.TabIndex = 12;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // EmployeeAddAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 355);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.tb_endWork);
            this.Controls.Add(this.tb_startWork);
            this.Controls.Add(this.tb_otherBreakLength);
            this.Controls.Add(this.tb_lenghtOfLunchBreak);
            this.Controls.Add(this.lb_endWork);
            this.Controls.Add(this.lb_otherBreakLength);
            this.Controls.Add(this.lb_lenghtOfLunchBreak);
            this.Controls.Add(this.lb_startWork);
            this.Controls.Add(this.lb_chooseDate);
            this.Controls.Add(this.dtp_DateTimePicker);
            this.Name = "EmployeeAddAttendanceForm";
            this.Text = "Add Attendance";
            this.Load += new System.EventHandler(this.EmployeeAddAttendanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_DateTimePicker;
        private System.Windows.Forms.Label lb_chooseDate;
        private System.Windows.Forms.Label lb_startWork;
        private System.Windows.Forms.Label lb_lenghtOfLunchBreak;
        private System.Windows.Forms.Label lb_otherBreakLength;
        private System.Windows.Forms.Label lb_endWork;
        private System.Windows.Forms.TextBox tb_lenghtOfLunchBreak;
        private System.Windows.Forms.TextBox tb_otherBreakLength;
        private System.Windows.Forms.TextBox tb_startWork;
        private System.Windows.Forms.TextBox tb_endWork;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_exit;
    }
}