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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lb_top = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_AddAttendance
            // 
            this.bt_AddAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_AddAttendance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.bt_AddAttendance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_AddAttendance.Location = new System.Drawing.Point(2, 2);
            this.bt_AddAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.bt_AddAttendance.Name = "bt_AddAttendance";
            this.bt_AddAttendance.Size = new System.Drawing.Size(160, 40);
            this.bt_AddAttendance.TabIndex = 0;
            this.bt_AddAttendance.Text = "Add Attendance";
            this.bt_AddAttendance.UseVisualStyleBackColor = true;
            this.bt_AddAttendance.Click += new System.EventHandler(this.bt_AddAttendance_Click);
            // 
            // bt_RemoveAttendance
            // 
            this.bt_RemoveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_RemoveAttendance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.bt_RemoveAttendance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_RemoveAttendance.Location = new System.Drawing.Point(2, 2);
            this.bt_RemoveAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.bt_RemoveAttendance.Name = "bt_RemoveAttendance";
            this.bt_RemoveAttendance.Size = new System.Drawing.Size(160, 40);
            this.bt_RemoveAttendance.TabIndex = 1;
            this.bt_RemoveAttendance.Text = "Remove Attendance";
            this.bt_RemoveAttendance.UseVisualStyleBackColor = true;
            this.bt_RemoveAttendance.Click += new System.EventHandler(this.bt_RemoveAttendance_Click);
            // 
            // bt_TotalAttendance
            // 
            this.bt_TotalAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_TotalAttendance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.bt_TotalAttendance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_TotalAttendance.Location = new System.Drawing.Point(2, 2);
            this.bt_TotalAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.bt_TotalAttendance.Name = "bt_TotalAttendance";
            this.bt_TotalAttendance.Size = new System.Drawing.Size(160, 40);
            this.bt_TotalAttendance.TabIndex = 2;
            this.bt_TotalAttendance.Text = "Total Attendance";
            this.bt_TotalAttendance.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.listView1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 120);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(376, 415);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            // 
            // lb_top
            // 
            this.lb_top.AutoSize = true;
            this.lb_top.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.lb_top.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_top.Location = new System.Drawing.Point(35, 86);
            this.lb_top.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_top.Name = "lb_top";
            this.lb_top.Size = new System.Drawing.Size(142, 27);
            this.lb_top.TabIndex = 4;
            this.lb_top.Text = "Logged in as: ";
            // 
            // bt_update
            // 
            this.bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_update.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.bt_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_update.Location = new System.Drawing.Point(2, 2);
            this.bt_update.Margin = new System.Windows.Forms.Padding(2);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(160, 40);
            this.bt_update.TabIndex = 5;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel3.Location = new System.Drawing.Point(440, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 50);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.bt_update);
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
            this.panel1.Location = new System.Drawing.Point(440, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 50);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.bt_AddAttendance);
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
            this.panel5.Location = new System.Drawing.Point(440, 337);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 50);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel6.Controls.Add(this.bt_RemoveAttendance);
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(164, 44);
            this.panel6.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Crimson;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel7.Location = new System.Drawing.Point(440, 408);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(170, 50);
            this.panel7.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel8.Controls.Add(this.bt_TotalAttendance);
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(164, 44);
            this.panel8.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-3, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(637, 26);
            this.flowLayoutPanel1.TabIndex = 24;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(591, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(633, 603);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lb_top);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeForm";
            this.Text = "Employee Screen";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_AddAttendance;
        private System.Windows.Forms.Button bt_RemoveAttendance;
        private System.Windows.Forms.Button bt_TotalAttendance;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lb_top;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label9;
    }
}