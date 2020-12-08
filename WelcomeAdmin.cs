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
            lb_welcome.Text = userClass.username + "!";
        }

     

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

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {

        }

        private void bt_Signout_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            form.ShowDialog();
        }

        private void bt_delete_Click_1(object sender, EventArgs e)
        {
            RemoveEmployee form = new RemoveEmployee();
            form.ShowDialog();
        }

        private void WelcomeAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
