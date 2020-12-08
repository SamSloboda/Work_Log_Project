using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Work_Log_Project
{
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
        {
            InitializeComponent();
            lb_user.Text = userClass.username;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            
            




        }
        /**
         * Loads the remaining data specific for the employee such as name, employee_id and creationtime to userClass class.
         * 
         */


        private void bt_refresh_Click(object sender, EventArgs e)
        {



            
        }

        private void bt_goback_Click(object sender, EventArgs e)
        {

        }

        private void bt_signout_Click(object sender, EventArgs e)
        {

        }

        private void RemoveEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
