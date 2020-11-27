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
        /**
        * @momo; @samon => Just add your connection string, and comment out the others. DO NOT DELETE OTHERS CONNECTION STRING!
        */

        {
            //SAM's connection string bellow
            public static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sam Sloboda\\source\\repos\\Work_Log_Project\\db_WorkLog.mdf;Integrated Security = True";
            
            //MOMO's connection string bellow
            //public static String connectionString = "INSERT YOUR CONNECTION STRING HERE";
            
            //SAMON's connection string bellow
            //public static String connectionString = "INSERT YOUR CONNECTION STRING HERE";

        }
    }

}
