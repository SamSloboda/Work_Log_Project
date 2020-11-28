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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        /**
         * Button handler for the Add Atendance new form is shown.
         */
        private void bt_AddAttendance_Click(object sender, EventArgs e)
        {
            EmployeeAddAttendanceForm addForm = new EmployeeAddAttendanceForm();
            addForm.ShowDialog();
        }

        private void bt_RemoveAttendance_Click(object sender, EventArgs e)
        {
            
        }
        /**
         * Loads the remaining data specific for the employee such as name, employee_id and creationtime to userClass class.
         * 
         */
        public void loadDataToClass(SqlConnection con) 
        {
            string sel = "select * FROM db_User right join Employee on db_User.user_id = Employee.user_id where db_User.user_id = @user_id ";
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
        }
        /**
         * Loads the listview.
         */
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            String cs = loginForm.DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(cs);

            loadDataToClass(con);
            
            con.Close();


            this.Text = userClass.firstName+" "+userClass.lastName+"'s Work Log";
            lb_top.Text = "Logged in as: " + userClass.firstName + " " + userClass.lastName;

            listView1.Columns.Add("Date", 100);
            listView1.Columns.Add("Start", 150);
            listView1.Columns.Add("End", 70);
            listView1.Columns.Add("Break", 70);
            listView1.View = View.Details;

            refreshListView();
        }
        /**
         * Button handler for update button. 
         */
        private void bt_update_Click(object sender, EventArgs e)
        {
            refreshListView();
        }
        /*
         * Refreshes the list. => Connects to database and refreshes the listView.
         */
        private void refreshListView()
        {
            String cs = loginForm.DatabaseConnect.connectionString;
            SqlConnection con1 = new SqlConnection(cs);
            ///show all the ACTIVE timeLogs for the current user
            String sel1 = "SELECT TimeLog.employee_id, TimeLog.startTime, TimeLog.endTime, TimeLog.breakTime FROM TimeLog where TimeLog.employee_id = '" + userClass.employee_id + "', TimeLog.activeLog = '"+ true +"'  ";
            SqlDataAdapter Da = new SqlDataAdapter(sel1, con1);
            DataSet ds = new DataSet();
            DataTable dt;

            Da.Fill(ds, "QueryResult_TimeLog");

            dt = ds.Tables["QueryResult_TimeLog"];
            con1.Close();
            int i;
            string[] starting;
            string[] ending;
            listView1.Items.Clear();
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                starting = dt.Rows[i].ItemArray[1].ToString().Split(' ');
                ending = dt.Rows[i].ItemArray[2].ToString().Split(' ');

                listView1.Items.Add(starting[0]);
                listView1.Items[i].SubItems.Add(starting[1] + " " + starting[2]);
                listView1.Items[i].SubItems.Add(ending[1] + " " + ending[2]);
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }


            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }


 }

