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

        private void bt_AddAttendance_Click(object sender, EventArgs e)
        {
            EmployeeAddAttendanceForm addForm = new EmployeeAddAttendanceForm();
            addForm.ShowDialog();
        }

        private void bt_RemoveAttendance_Click(object sender, EventArgs e)
        {
            EmployeeRemoveAttendaceForm removeForm = new EmployeeRemoveAttendaceForm();
            removeForm.ShowDialog();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Date", 100);
            listView1.Columns.Add("Start", 150);
            listView1.Columns.Add("End", 70);
            listView1.Columns.Add("Break", 70);

            listView1.View = View.Details;

            String constr = loginForm.DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);  // create the database connecting

            String sel = "SELECT TimeLog.employee_id, TimeLog.startTime, TimeLog.endTime, TimeLog.breakTime FROM TimeLog where TimeLog.employee_id = '2' ";  // Create the SQL query to be executed
            SqlDataAdapter Da = new SqlDataAdapter(sel, con); // Create the tableAdapter/ dataAdapter
            DataSet ds = new DataSet();  // Need the Dataset to populate data from the table
            DataTable dt;

            Da.Fill(ds, "QueryResult_TimeLog"); // Lead query result in the dataset- given a table name 'QueryResult_TimeLog', a dataset can have multiple such table/query resutl


            dt = ds.Tables["QueryResult_TimeLog"];
            con.Close();
            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
