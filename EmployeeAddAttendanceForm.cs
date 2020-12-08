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
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void EmployeeAddAttendanceForm_Load(object sender, EventArgs e)
        {

        }
        /*
         * Exit button handler.
         */
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
         * Submit button handler.
         */
        private void bt_submit_Click(object sender, EventArgs e)
        {   
            /// assinging the values from user inputs to the variables
            DateTime startTime = dt_startTime.Value;
            DateTime endTime = dt_endTime.Value;
            int totalBreak = (int)(ud_lunchBreak.Value + ud_otherBreaks.Value);
            bool activeLog = true; ///make the log active as we add it

            ///creating connection and command
            String constr = loginForm.DatabaseConnect.connectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = con.CreateCommand();
            try
            {
                //creating  queery and executing the command
                string query = "insert into TimeLog (employee_id, startTime, endTime, breakTime, activeLog) values('"+ userClass.employee_id + "','" + startTime + "','" + endTime + "','" + totalBreak + "', '"+ activeLog +"')";
                cmd.CommandText = query;
                con.Open();
                
                ///creating flag to see if the insertion went smooth
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

        private void lb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            dt_startTime.Value = DateTime.Now;
            dt_endTime.Value = DateTime.Now;
            ud_lunchBreak.Value = 0;
            ud_otherBreaks.Value = 0;

        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
