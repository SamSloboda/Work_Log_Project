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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();

            String constr = loginForm.DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);
            string query = "SELECT Employee.user_id AS 'USER ID' ,employee_id AS 'Employee ID' ,firstName AS 'First Name' ,middleName AS 'Middle Name',lastName AS'Last Name' ,creationTime AS 'Time of Creation' ,username AS 'Username', password AS 'Password' ,adminAcc AS'IS Admin?' ,activeUser AS 'Activated'  FROM Employee  JOIN db_User ON Employee.user_id = db_User.user_id";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee");
            dataGridView1.DataSource = ds.Tables["Employee"].DefaultView;
         }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void bt_addEmployee_Click(object sender, EventArgs e)
        {
            EmployerAddEmployeeForm addEmployee = new EmployerAddEmployeeForm();
            addEmployee.ShowDialog();
        }

        private void bt_removeEmployee_Click(object sender, EventArgs e)
        {
            EmployerRemoveEmployeeForm removeEmployee = new EmployerRemoveEmployeeForm();
            removeEmployee.ShowDialog();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminPage_Load(object sender, EventArgs e)
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

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
