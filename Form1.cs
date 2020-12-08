using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Log_Project
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet.Users);

        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.AddNew();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.RemoveCurrent();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

            //hgeklsadhbaifuhsifshdiauhbdsijka
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
