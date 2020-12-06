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
    public partial class EmployerAddEmployeeForm : Form
    {
        public EmployerAddEmployeeForm()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_active_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EmployerAddEmployeeForm_Load(object sender, EventArgs e)
        {

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

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
