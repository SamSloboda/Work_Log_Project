namespace Work_Log_Project
{
    partial class EmployeeForm
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
            this.bt_AddAttendance = new System.Windows.Forms.Button();
            this.bt_RemoveAttendance = new System.Windows.Forms.Button();
            this.bt_TotalAttendance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_AddAttendance
            // 
            this.bt_AddAttendance.Location = new System.Drawing.Point(44, 393);
            this.bt_AddAttendance.Name = "bt_AddAttendance";
            this.bt_AddAttendance.Size = new System.Drawing.Size(131, 35);
            this.bt_AddAttendance.TabIndex = 0;
            this.bt_AddAttendance.Text = "Add Attendance";
            this.bt_AddAttendance.UseVisualStyleBackColor = true;
            // 
            // bt_RemoveAttendance
            // 
            this.bt_RemoveAttendance.Location = new System.Drawing.Point(190, 393);
            this.bt_RemoveAttendance.Name = "bt_RemoveAttendance";
            this.bt_RemoveAttendance.Size = new System.Drawing.Size(153, 35);
            this.bt_RemoveAttendance.TabIndex = 1;
            this.bt_RemoveAttendance.Text = "Remove Attendance";
            this.bt_RemoveAttendance.UseVisualStyleBackColor = true;
            // 
            // bt_TotalAttendance
            // 
            this.bt_TotalAttendance.Location = new System.Drawing.Point(359, 393);
            this.bt_TotalAttendance.Name = "bt_TotalAttendance";
            this.bt_TotalAttendance.Size = new System.Drawing.Size(153, 35);
            this.bt_TotalAttendance.TabIndex = 2;
            this.bt_TotalAttendance.Text = "Total Attendance";
            this.bt_TotalAttendance.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.bt_TotalAttendance);
            this.Controls.Add(this.bt_RemoveAttendance);
            this.Controls.Add(this.bt_AddAttendance);
            this.Name = "EmployeeForm";
            this.Text = "Employee Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_AddAttendance;
        private System.Windows.Forms.Button bt_RemoveAttendance;
        private System.Windows.Forms.Button bt_TotalAttendance;
    }
}