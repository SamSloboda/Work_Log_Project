namespace Work_Log_Project
{
    partial class Administrator
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label full_NameLabel;
            System.Windows.Forms.Label position_A_E_Label;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.usersDataSet = new Work_Log_Project.UsersDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Work_Log_Project.UsersDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Work_Log_Project.UsersDataSetTableAdapters.TableAdapterManager();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.full_NameTextBox = new System.Windows.Forms.TextBox();
            this.position_A_E_TextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            employeeIDLabel = new System.Windows.Forms.Label();
            full_NameLabel = new System.Windows.Forms.Label();
            position_A_E_Label = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            employeeIDLabel.Location = new System.Drawing.Point(43, 55);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 2;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // full_NameLabel
            // 
            full_NameLabel.AutoSize = true;
            full_NameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            full_NameLabel.Location = new System.Drawing.Point(43, 81);
            full_NameLabel.Name = "full_NameLabel";
            full_NameLabel.Size = new System.Drawing.Size(57, 13);
            full_NameLabel.TabIndex = 4;
            full_NameLabel.Text = "Full Name:";
            // 
            // position_A_E_Label
            // 
            position_A_E_Label.AutoSize = true;
            position_A_E_Label.ForeColor = System.Drawing.Color.WhiteSmoke;
            position_A_E_Label.Location = new System.Drawing.Point(43, 107);
            position_A_E_Label.Name = "position_A_E_Label";
            position_A_E_Label.Size = new System.Drawing.Size(72, 13);
            position_A_E_Label.TabIndex = 6;
            position_A_E_Label.Text = "Position(A\\E):";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            usernameLabel.Location = new System.Drawing.Point(43, 133);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            passwordLabel.Location = new System.Drawing.Point(43, 159);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password:";
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.usersDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Work_Log_Project.UsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(12, 282);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(642, 138);
            this.usersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Full Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Position(A\\E)";
            this.dataGridViewTextBoxColumn3.HeaderText = "Position(A\\E)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn4.HeaderText = "Username";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn5.HeaderText = "Password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_submit);
            this.groupBox1.Controls.Add(this.bt_delete);
            this.groupBox1.Controls.Add(this.bt_create);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(405, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select an action";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_submit
            // 
            this.bt_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_submit.Location = new System.Drawing.Point(113, 89);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(59, 21);
            this.bt_submit.TabIndex = 5;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_delete.Location = new System.Drawing.Point(113, 62);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(59, 21);
            this.bt_delete.TabIndex = 4;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_create
            // 
            this.bt_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_create.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_create.Location = new System.Drawing.Point(113, 35);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(59, 21);
            this.bt_create.TabIndex = 3;
            this.bt_create.Text = "Create";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(27, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delete a record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save the changes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new record";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(121, 52);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.employeeIDTextBox.TabIndex = 3;
            // 
            // full_NameTextBox
            // 
            this.full_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Full Name", true));
            this.full_NameTextBox.Location = new System.Drawing.Point(121, 78);
            this.full_NameTextBox.Name = "full_NameTextBox";
            this.full_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.full_NameTextBox.TabIndex = 5;
            // 
            // position_A_E_TextBox
            // 
            this.position_A_E_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Position(A\\E)", true));
            this.position_A_E_TextBox.Location = new System.Drawing.Point(121, 104);
            this.position_A_E_TextBox.Name = "position_A_E_TextBox";
            this.position_A_E_TextBox.Size = new System.Drawing.Size(104, 20);
            this.position_A_E_TextBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(121, 130);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(104, 20);
            this.usernameTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(121, 156);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(104, 20);
            this.passwordTextBox.TabIndex = 11;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "Active", true));
            this.activeCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.activeCheckBox.Location = new System.Drawing.Point(121, 182);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activeCheckBox.TabIndex = 13;
            this.activeCheckBox.Text = "Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(full_NameLabel);
            this.Controls.Add(this.full_NameTextBox);
            this.Controls.Add(position_A_E_Label);
            this.Controls.Add(this.position_A_E_TextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usersDataGridView);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private UsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox full_NameTextBox;
        private System.Windows.Forms.TextBox position_A_E_TextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
    }
}