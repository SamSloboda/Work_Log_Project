namespace Work_Log_Project
{
    partial class EmployerForm
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
            this.bt_addEmployee = new System.Windows.Forms.Button();
            this.bt_removeEmployee = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(574, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_addEmployee
            // 
            this.bt_addEmployee.Location = new System.Drawing.Point(42, 457);
            this.bt_addEmployee.Name = "bt_addEmployee";
            this.bt_addEmployee.Size = new System.Drawing.Size(185, 40);
            this.bt_addEmployee.TabIndex = 1;
            this.bt_addEmployee.Text = "Add Employee";
            this.bt_addEmployee.UseVisualStyleBackColor = true;
            // 
            // bt_removeEmployee
            // 
            this.bt_removeEmployee.Location = new System.Drawing.Point(233, 457);
            this.bt_removeEmployee.Name = "bt_removeEmployee";
            this.bt_removeEmployee.Size = new System.Drawing.Size(185, 40);
            this.bt_removeEmployee.TabIndex = 2;
            this.bt_removeEmployee.Text = "Remove Employee";
            this.bt_removeEmployee.UseVisualStyleBackColor = true;
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(424, 457);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(185, 40);
            this.bt_exit.TabIndex = 3;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 507);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_removeEmployee);
            this.Controls.Add(this.bt_addEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployerForm";
            this.Text = "Employer Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_addEmployee;
        private System.Windows.Forms.Button bt_removeEmployee;
        private System.Windows.Forms.Button bt_exit;
    }
}