namespace Work_Log_Project
{
    partial class EmployerAddEmployeeForm
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
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_confirmPassword = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_passwordConfirm = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(39, 312);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(122, 23);
            this.bt_submit.TabIndex = 0;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(167, 312);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(119, 23);
            this.bt_clear.TabIndex = 1;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(292, 312);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(113, 23);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(112, 30);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(49, 17);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Name:";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Location = new System.Drawing.Point(120, 81);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(41, 17);
            this.lb_role.TabIndex = 4;
            this.lb_role.Text = "Role:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(84, 130);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(77, 17);
            this.lb_username.TabIndex = 5;
            this.lb_username.Text = "Username:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(88, 180);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(73, 17);
            this.lb_password.TabIndex = 6;
            this.lb_password.Text = "Password:";
            // 
            // lb_confirmPassword
            // 
            this.lb_confirmPassword.AutoSize = true;
            this.lb_confirmPassword.Location = new System.Drawing.Point(36, 230);
            this.lb_confirmPassword.Name = "lb_confirmPassword";
            this.lb_confirmPassword.Size = new System.Drawing.Size(125, 17);
            this.lb_confirmPassword.TabIndex = 7;
            this.lb_confirmPassword.Text = "Confirm Password:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(207, 27);
            this.tb_name.MaxLength = 10;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(154, 22);
            this.tb_name.TabIndex = 0;
            // 
            // tb_passwordConfirm
            // 
            this.tb_passwordConfirm.Location = new System.Drawing.Point(207, 227);
            this.tb_passwordConfirm.MaxLength = 10;
            this.tb_passwordConfirm.Name = "tb_passwordConfirm";
            this.tb_passwordConfirm.Size = new System.Drawing.Size(154, 22);
            this.tb_passwordConfirm.TabIndex = 4;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(207, 127);
            this.tb_username.MaxLength = 10;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(154, 22);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(207, 177);
            this.tb_password.MaxLength = 10;
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(154, 22);
            this.tb_password.TabIndex = 3;
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Employer",
            "Employee"});
            this.cb_role.Location = new System.Drawing.Point(207, 77);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(154, 24);
            this.cb_role.TabIndex = 1;
            // 
            // EmployerAddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 354);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_passwordConfirm);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_confirmPassword);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_submit);
            this.Name = "EmployerAddEmployeeForm";
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_confirmPassword;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_passwordConfirm;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.ComboBox cb_role;
    }
}