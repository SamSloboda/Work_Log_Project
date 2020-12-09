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
    public partial class WelcomeAdmin : Form
    {
        public WelcomeAdmin()
        {
            InitializeComponent();
            lb_welcome.Text ="Admin " + userClass.username;
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void bt_add_Click(object sender, EventArgs e)
        {
            EmployerAddEmployeeForm newForm = new EmployerAddEmployeeForm();
            newForm.ShowDialog();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            RemoveEmployee form =new RemoveEmployee();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO: Not functional at the moment.
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            EditUserForm formm = new EditUserForm();
            formm.ShowDialog();
        }

        private void bt_Signout_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void bt_delete_Click_1(object sender, EventArgs e)
        {
            RemoveEmployee form = new RemoveEmployee();
            form.ShowDialog();
        }

        private void WelcomeAdmin_Load(object sender, EventArgs e)
        {

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_welcome_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
