namespace Work_Log_Project
{
    partial class EmployerRemoveEmployeeForm
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
            this.bt_removeEmployee = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_removeEmployee
            // 
            this.bt_removeEmployee.Location = new System.Drawing.Point(92, 386);
            this.bt_removeEmployee.Name = "bt_removeEmployee";
            this.bt_removeEmployee.Size = new System.Drawing.Size(165, 32);
            this.bt_removeEmployee.TabIndex = 0;
            this.bt_removeEmployee.Text = "Remove Emloyee";
            this.bt_removeEmployee.UseVisualStyleBackColor = true;
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(288, 386);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(165, 32);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 354);
            this.dataGridView1.TabIndex = 2;
            // 
            // EmployerRemoveEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_removeEmployee);
            this.Name = "EmployerRemoveEmployeeForm";
            this.Text = "EmployerRemoveEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_removeEmployee;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}