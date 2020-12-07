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

        private void bt_submit_Click(object sender, EventArgs e)
        {
           // if(tb_firstname.Text==null&&tb_lastname.Text==null||tb_username.Text==null||)
            Boolean redflag = false;
            string firstname = tb_firstname.Text;
            string middlename = tb_middleName.Text;
            string lastname = tb_lastname.Text;
            string password = null;
            string username = tb_username.Text;

            Boolean isAdmin = bt_admin.Checked;
            Boolean isActive = bt_active.Checked;

            if (tb_password.Text == tb_confirmpassword.Text)
            {
                password = tb_password.Text;
                lb_alert.Visible = false;
                lb_alert2.Visible = false;
                redflag = false;
            }
            else
            {
                lb_alert.Visible = true;
                lb_alert2.Visible = true;
                redflag = true;
            }


            // Lets get the connection to get Existing data!

            string connectionstring = loginForm.DatabaseConnect.connectionString;
            string query = "SELECT * FROM Employee";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();

            //Lets create the adapter
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            adapter.Dispose();

            List<string> firstNames = new List<string>(table.Rows.Count);
            List<string> lastNames = new List<string>(table.Rows.Count);
            List<int> ids = new List<int>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
                firstNames.Add((string)row["firstName"]);
            foreach (DataRow row in table.Rows)
                lastNames.Add((string)row["lastName"]);
            foreach (DataRow row in table.Rows)
                ids.Add((int)row["user_id"]);
            // As we need unique id for Our new added Record. we will take the highest id and add 1 to it. 
            int maxForID = ids.Max();
            MessageBox.Show("" + maxForID);
            Boolean inspectNames = firstNames.Contains(tb_firstname.Text) && lastNames.Contains(tb_lastname.Text);
            if (inspectNames)
            {
                MessageBox.Show("Duplicate User Found.Please check your entry!");
                redflag = true;
                
                lb_namealert.Visible = true;
                lb_namealert2.Visible = true;
                lb_namealert3.Visible = true;
            }
            else
            {
                redflag = false;
                lb_namealert.Visible = false;
                lb_namealert2.Visible = false;
                lb_namealert3.Visible = false;

            }
            string newquery = "INSERT INTO db_User VALUES (" + (maxForID + 1) + ", '" + username + "', '" + password+"', " + isAdmin + ", " + isActive + ");";
            //if (!isAdmin) {
            //newquery = newquery+ "\n  INSERT INTO Employees VALUES("
            
            
            
        }

    

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_firstname.Text = "";
            tb_middleName.Text = "";
            tb_lastname.Text = "";
            tb_username.Text = "";
            tb_password.Text = "";
            tb_confirmpassword.Text = "";
            lb_alert.Visible = false;
            lb_alert2.Visible = false;
            bt_active.Checked = false;
            bt_admin.Checked = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
