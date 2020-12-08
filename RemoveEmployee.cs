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
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void bt_delete_Click(object sender, EventArgs e)
        {
           
            




        }
        /**
         * Loads the remaining data specific for the employee such as name, employee_id and creationtime to userClass class.
         * 
         */


        private void bt_refresh_Click(object sender, EventArgs e)
        {
            refreshListView();


            
        }

        private void bt_goback_Click(object sender, EventArgs e)
        {

        }

        private void bt_signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm form = new loginForm();
            form.ShowDialog();
        }

        public void loadDataToClass(SqlConnection con)
        {
            string sel = "SELECT * FROM Employee right join db_User on db_User.user_id = Employee.user_id where db_User.user_id = @user_id ";
            SqlCommand myCommand = new SqlCommand(sel, con);
            SqlParameter uID = new SqlParameter("@user_id", SqlDbType.Int);
            uID.Value = userClass.user_id;
            myCommand.Parameters.Add(uID);
            myCommand.Connection.Open();


            SqlDataReader myReader1 = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            if (myReader1.Read() == true)
            {
                userClass.employee_id = myReader1.GetInt32(6);
                userClass.firstName = myReader1.GetString(7);
                if (myReader1.IsDBNull(8) == false)
                {
                    userClass.middleName = myReader1.GetString(8);
                }
                userClass.lastName = myReader1.GetString(9);
                userClass.creationTime = myReader1.GetDateTime(10);
            }

            con.Close();
        }

        private void RemoveEmployee_Load(object sender, EventArgs e)
        {

            string cs = loginForm.DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM Employee";
            SqlCommand myCommand = new SqlCommand(query, con);
            myCommand.Connection.Open();
            SqlDataReader myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            listView1.Columns.Add("User ID",50);
            // listView1.Columns.Add("Employee ID");
            listView1.Columns.Add("First Name",100);
            // listView1.Columns.Add("Middle Name");
            listView1.Columns.Add("Last Name",130);
            listView1.Columns.Add("Date of Creation", 180);

            if (myreader.Read())
            {
               
                listView1.View = View.Details;
                refreshListView();
                //  listView1.Items.Add("Employee ID", "First Name", "Middle Name", "Last Name");
            }
        }

        private void refreshListView()
            {
            String cs = loginForm.DatabaseConnect.connectionString;
            SqlConnection con1 = new SqlConnection(cs);
            ///show all the ACTIVE timeLogs for the current user
            String sel1 = "SELECT user_id, firstName, lastName, creationTime FROM Employee";
            SqlDataAdapter Da = new SqlDataAdapter(sel1, con1);
            DataSet ds = new DataSet();
            DataTable dt;

            Da.Fill(ds, "QueryResult");

            dt = ds.Tables["QueryResult"];
            con1.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["user_id"].ToString());
                listitem.SubItems.Add(dr["firstName"].ToString());
                listitem.SubItems.Add(dr["lastName"].ToString());
                listitem.SubItems.Add(dr["creationTime"].ToString());
                listView1.Items.Add(listitem);
            }

        }


        

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
