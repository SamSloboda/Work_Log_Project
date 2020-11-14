namespace Work_Log_Project
{
    partial class EmployeeRemoveAttendaceForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_removeAttendance = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_removeAttendance
            // 
            this.bt_removeAttendance.Location = new System.Drawing.Point(39, 436);
            this.bt_removeAttendance.Name = "bt_removeAttendance";
            this.bt_removeAttendance.Size = new System.Drawing.Size(168, 23);
            this.bt_removeAttendance.TabIndex = 1;
            this.bt_removeAttendance.Text = "Remove Attendance";
            this.bt_removeAttendance.UseVisualStyleBackColor = true;
            this.bt_removeAttendance.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(213, 436);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(168, 23);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // EmployeeRemoveAttendaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 492);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_removeAttendance);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeRemoveAttendaceForm";
            this.Text = "Remove Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_removeAttendance;
        private System.Windows.Forms.Button bt_exit;
    }
}