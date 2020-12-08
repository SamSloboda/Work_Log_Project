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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            employeeIDLabel = new System.Windows.Forms.Label();
            full_NameLabel = new System.Windows.Forms.Label();
            position_A_E_Label = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            employeeIDLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            employeeIDLabel.Location = new System.Drawing.Point(20, 20);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(122, 24);
            employeeIDLabel.TabIndex = 2;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // full_NameLabel
            // 
            full_NameLabel.AutoSize = true;
            full_NameLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            full_NameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            full_NameLabel.Location = new System.Drawing.Point(20, 54);
            full_NameLabel.Name = "full_NameLabel";
            full_NameLabel.Size = new System.Drawing.Size(103, 24);
            full_NameLabel.TabIndex = 4;
            full_NameLabel.Text = "Full Name:";
            // 
            // position_A_E_Label
            // 
            position_A_E_Label.AutoSize = true;
            position_A_E_Label.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            position_A_E_Label.ForeColor = System.Drawing.Color.WhiteSmoke;
            position_A_E_Label.Location = new System.Drawing.Point(20, 88);
            position_A_E_Label.Name = "position_A_E_Label";
            position_A_E_Label.Size = new System.Drawing.Size(125, 24);
            position_A_E_Label.TabIndex = 6;
            position_A_E_Label.Text = "Position(A\\E):";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            usernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            usernameLabel.Location = new System.Drawing.Point(20, 122);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(100, 24);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            passwordLabel.Location = new System.Drawing.Point(20, 157);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(96, 24);
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
            this.usersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.GridColor = System.Drawing.Color.Crimson;
            this.usersDataGridView.Location = new System.Drawing.Point(18, 17);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(646, 153);
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
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(326, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_submit
            // 
            this.bt_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_submit.Font = new System.Drawing.Font("Trebuchet MS", 6.75F);
            this.bt_submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_submit.Location = new System.Drawing.Point(3, 3);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(107, 23);
            this.bt_submit.TabIndex = 5;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_delete.Font = new System.Drawing.Font("Trebuchet MS", 6.75F);
            this.bt_delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_delete.Location = new System.Drawing.Point(3, 3);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(107, 23);
            this.bt_delete.TabIndex = 4;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_create
            // 
            this.bt_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_create.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_create.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_create.Location = new System.Drawing.Point(3, 3);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(107, 23);
            this.bt_create.TabIndex = 3;
            this.bt_create.Text = "Create";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "~Delete a record~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "~Save the changes~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "~Add a new record~";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.BackColor = System.Drawing.Color.Crimson;
            this.employeeIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeIDTextBox.Location = new System.Drawing.Point(169, 22);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(104, 22);
            this.employeeIDTextBox.TabIndex = 3;
            // 
            // full_NameTextBox
            // 
            this.full_NameTextBox.BackColor = System.Drawing.Color.Crimson;
            this.full_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.full_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Full Name", true));
            this.full_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_NameTextBox.Location = new System.Drawing.Point(169, 56);
            this.full_NameTextBox.Name = "full_NameTextBox";
            this.full_NameTextBox.Size = new System.Drawing.Size(104, 22);
            this.full_NameTextBox.TabIndex = 5;
            // 
            // position_A_E_TextBox
            // 
            this.position_A_E_TextBox.BackColor = System.Drawing.Color.Crimson;
            this.position_A_E_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.position_A_E_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Position(A\\E)", true));
            this.position_A_E_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position_A_E_TextBox.Location = new System.Drawing.Point(169, 90);
            this.position_A_E_TextBox.Name = "position_A_E_TextBox";
            this.position_A_E_TextBox.Size = new System.Drawing.Size(104, 22);
            this.position_A_E_TextBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Crimson;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(169, 124);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(104, 22);
            this.usernameTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Crimson;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(169, 159);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(104, 22);
            this.passwordTextBox.TabIndex = 11;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "Active", true));
            this.activeCheckBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F);
            this.activeCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.activeCheckBox.Location = new System.Drawing.Point(95, 192);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(81, 24);
            this.activeCheckBox.TabIndex = 13;
            this.activeCheckBox.Text = "Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel5.Location = new System.Drawing.Point(202, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 35);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel6.Controls.Add(this.bt_create);
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(113, 29);
            this.panel6.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel1.Location = new System.Drawing.Point(202, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 35);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.bt_delete);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 29);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel3.Location = new System.Drawing.Point(202, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 35);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.bt_submit);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 29);
            this.panel4.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.label3);
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.panel8.Location = new System.Drawing.Point(326, 244);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(337, 52);
            this.panel8.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.panel9.Location = new System.Drawing.Point(0, 95);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(337, 52);
            this.panel9.TabIndex = 21;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.label2);
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.panel10.Location = new System.Drawing.Point(326, 116);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(337, 52);
            this.panel10.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel7.Controls.Add(this.usernameTextBox);
            this.panel7.Controls.Add(this.employeeIDTextBox);
            this.panel7.Controls.Add(employeeIDLabel);
            this.panel7.Controls.Add(this.activeCheckBox);
            this.panel7.Controls.Add(passwordLabel);
            this.panel7.Controls.Add(usernameLabel);
            this.panel7.Controls.Add(position_A_E_Label);
            this.panel7.Controls.Add(full_NameLabel);
            this.panel7.Controls.Add(this.passwordTextBox);
            this.panel7.Controls.Add(this.full_NameTextBox);
            this.panel7.Controls.Add(this.position_A_E_TextBox);
            this.panel7.Location = new System.Drawing.Point(17, 88);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(294, 224);
            this.panel7.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(637, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(682, 27);
            this.flowLayoutPanel1.TabIndex = 25;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.panel11.Controls.Add(this.usersDataGridView);
            this.panel11.Location = new System.Drawing.Point(-1, 368);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(682, 189);
            this.panel11.TabIndex = 27;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panel16.Location = new System.Drawing.Point(2, 618);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(679, 19);
            this.panel16.TabIndex = 41;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Crimson;
            this.panel15.Location = new System.Drawing.Point(2, 630);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(679, 10);
            this.panel15.TabIndex = 40;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(679, 640);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
    }
}