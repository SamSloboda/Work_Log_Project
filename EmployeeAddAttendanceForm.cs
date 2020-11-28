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
    public partial class EmployeeAddAttendanceForm : Form
    {
        public EmployeeAddAttendanceForm()
        {
            InitializeComponent();
        }

        private void EmployeeAddAttendanceForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            DateTime startTime = dt_startTime.Value;
            DateTime endTime = dt_endTime.Value;
            int totalBreak = (int)(ud_lunchBreak.Value + ud_otherBreaks.Value);

            String constr = loginForm.DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = con.CreateCommand();
            try
            {
                //form the SQL insert query using the given data
                string query = "insert into TimeLog (employee_id, startTime, endTime, breakTime) values('"+ userClass.employee_id + "','" + startTime + "','" + endTime + "','" + totalBreak + "')";
                cmd.CommandText = query;
                con.Open(); 
                Int32 returnFlag = (Int32)cmd.ExecuteNonQuery();
                if (returnFlag > 0)
                    MessageBox.Show("Inserted Successfully");
                else
                    MessageBox.Show("Something went wrong");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                cmd.Dispose();
                con.Close();


            }


        }
    }
}
