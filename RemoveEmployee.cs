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
           

            //string connectionstring = loginForm.DatabaseConnect.connectionString;
            //SqlConnection connection = new SqlConnection(connectionstring);
            string message = "Are you sure you want to delete the selected Employee?";
            string caption = " Deactivate the User Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(this, message, caption, buttons, icon);

            if (result == DialogResult.Yes)
            {
                String cs = loginForm.DatabaseConnect.connectionString;
                SqlConnection con = new SqlConnection(cs);

                try
                {
                    /// taking input which row is selected
                    int idToRemove = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);



                    string query = "UPDATE db_User SET db_User.activeUser = @activelog where user_id = @logID ";
                    SqlCommand myCommand = new SqlCommand(query, con);

                    SqlParameter lActive = new SqlParameter("@activelog", SqlDbType.Bit);
                    SqlParameter lID = new SqlParameter("@logID", SqlDbType.Int);
                    lActive.Value = false;
                    lID.Value = idToRemove;

                    myCommand.Parameters.Add(lID);
                    myCommand.Parameters.Add(lActive);

                    myCommand.Connection.Open();

                    Int32 returnFlag = (Int32)myCommand.ExecuteNonQuery();
                    if (returnFlag > 0)
                    {
                        MessageBox.Show("The stated user is deactivated.", "Operation successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshListView();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {

            }







        }
        /**
         * Loads the remaining data specific for the employee such as name, employee_id and creationtime to userClass class.
         * 
         */


        private void bt_revive_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to revive the selected Employee?";
            string caption = " Reviving the User Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(this, message, caption, buttons, icon);

            if (result == DialogResult.Yes)
            {
                String cs = loginForm.DatabaseConnect.connectionString;
                SqlConnection con = new SqlConnection(cs);

                try
                {
                    /// taking input which row is selected
                    int idToRevive = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);



                    string query = "UPDATE db_User SET db_User.activeUser = @activelog where user_id = @logID ";
                    SqlCommand myCommand = new SqlCommand(query, con);

                    SqlParameter lActive = new SqlParameter("@activelog", SqlDbType.Bit);
                    SqlParameter lID = new SqlParameter("@logID", SqlDbType.Int);
                    lActive.Value = true;
                    lID.Value = idToRevive;

                    myCommand.Parameters.Add(lID);
                    myCommand.Parameters.Add(lActive);

                    myCommand.Connection.Open();

                    Int32 returnFlag = (Int32)myCommand.ExecuteNonQuery();
                    if (returnFlag > 0)
                    {
                        MessageBox.Show("The stated user is activated. Employee can now access his/her account!", "Operation successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshListView();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {

            }



        }

        private void bt_goback_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeAdmin page = new WelcomeAdmin();
            page.ShowDialog();
        }

        private void bt_signout_Click(object sender, EventArgs e)
        {
            foreach(Form openedform in Application.OpenForms)
            {
                
                openedform.Hide();
            }
            loginForm form = new loginForm();
            form.ShowDialog();
        }

        

        private void RemoveEmployee_Load(object sender, EventArgs e)
        {

            string cs = loginForm.DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM Employee";
            SqlCommand myCommand = new SqlCommand(query, con);
            myCommand.Connection.Open();
            SqlDataReader myreader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            listView1.FullRowSelect=true;
            listView1.Columns.Add("UserID",40);
            listView1.Columns.Add("Emp.ID",40);
            listView1.Columns.Add("First Name",80);
            // listView1.Columns.Add("Middle Name");
            listView1.Columns.Add("Last Name",100);
            listView1.Columns.Add("Active User", 160);
           
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
            String sel1 = "SELECT Employee.user_id,employee_id, firstName, lastName, activeUser FROM Employee JOIN db_User ON db_User.user_id=Employee.user_id";
            SqlDataAdapter Da = new SqlDataAdapter(sel1, con1);
            DataSet ds = new DataSet();
            DataTable dt;
       
            Da.Fill(ds, "QueryResult");

            dt = ds.Tables["QueryResult"];
            con1.Close();
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["user_id"].ToString());
                listitem.SubItems.Add(dr["employee_id"].ToString());
                listitem.SubItems.Add(dr["firstName"].ToString());
                listitem.SubItems.Add(dr["lastName"].ToString());
                listitem.SubItems.Add(dr["activeUser"].ToString());
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
