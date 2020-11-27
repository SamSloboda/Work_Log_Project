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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            //Login form
            EmployerForm employerForm = new EmployerForm();
            employerForm.ShowDialog();
            //Administrator Form

            Administrator adminn = new Administrator();
            adminn.ShowDialog();

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        public class DatabaseConnect 
        {
            public static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sam Sloboda\\source\\repos\\Work_Log_Project\\Users.mdf;Integrated Security = True";
        }
    }

}
