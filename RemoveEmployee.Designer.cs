namespace Work_Log_Project
{
    partial class RemoveEmployee
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.bt_goback = new System.Windows.Forms.Button();
            this.bt_signout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 332);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged in as: ";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(131, 102);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(0, 13);
            this.lb_user.TabIndex = 2;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(487, 194);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(115, 33);
            this.bt_delete.TabIndex = 3;
            this.bt_delete.Text = "Delete Employee";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(487, 233);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(115, 32);
            this.bt_refresh.TabIndex = 4;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // bt_goback
            // 
            this.bt_goback.Location = new System.Drawing.Point(487, 271);
            this.bt_goback.Name = "bt_goback";
            this.bt_goback.Size = new System.Drawing.Size(115, 34);
            this.bt_goback.TabIndex = 5;
            this.bt_goback.Text = "Go Back";
            this.bt_goback.UseVisualStyleBackColor = true;
            this.bt_goback.Click += new System.EventHandler(this.bt_goback_Click);
            // 
            // bt_signout
            // 
            this.bt_signout.Location = new System.Drawing.Point(487, 311);
            this.bt_signout.Name = "bt_signout";
            this.bt_signout.Size = new System.Drawing.Size(115, 34);
            this.bt_signout.TabIndex = 6;
            this.bt_signout.Text = "Sign Out";
            this.bt_signout.UseVisualStyleBackColor = true;
            this.bt_signout.Click += new System.EventHandler(this.bt_signout_Click);
            // 
            // RemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 464);
            this.Controls.Add(this.bt_signout);
            this.Controls.Add(this.bt_goback);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "RemoveEmployee";
            this.Text = "RemoveEmployee";
            this.Load += new System.EventHandler(this.RemoveEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button bt_goback;
        private System.Windows.Forms.Button bt_signout;
    }
}