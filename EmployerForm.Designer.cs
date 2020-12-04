namespace Work_Log_Project
{
    partial class AdminPage
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(857, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_addEmployee
            // 
            this.bt_addEmployee.Location = new System.Drawing.Point(30, 405);
            this.bt_addEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_addEmployee.Name = "bt_addEmployee";
            this.bt_addEmployee.Size = new System.Drawing.Size(139, 32);
            this.bt_addEmployee.TabIndex = 1;
            this.bt_addEmployee.Text = "Add Employee";
            this.bt_addEmployee.UseVisualStyleBackColor = true;
            this.bt_addEmployee.Click += new System.EventHandler(this.bt_addEmployee_Click);
            // 
            // bt_removeEmployee
            // 
            this.bt_removeEmployee.Location = new System.Drawing.Point(173, 405);
            this.bt_removeEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_removeEmployee.Name = "bt_removeEmployee";
            this.bt_removeEmployee.Size = new System.Drawing.Size(139, 32);
            this.bt_removeEmployee.TabIndex = 2;
            this.bt_removeEmployee.Text = "Remove Employee";
            this.bt_removeEmployee.UseVisualStyleBackColor = true;
            this.bt_removeEmployee.Click += new System.EventHandler(this.bt_removeEmployee_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(316, 405);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(139, 32);
            this.bt_exit.TabIndex = 3;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 474);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_removeEmployee);
            this.Controls.Add(this.bt_addEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminPage";
            this.Text = "Admin Page";
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