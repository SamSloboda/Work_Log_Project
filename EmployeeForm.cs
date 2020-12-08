﻿using System;
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
        
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
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
            try
            {
                string test = listView1.SelectedItems[0].Text;

                string message = "Are you sure you want to delete this time log entry?";
                string caption = " Delete the Time Log Entry";
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
                        int log_id_remove = Int32.Parse(listView1.SelectedItems[0].Text);

                        string query = "update TimeLog set TimeLog.activeLog = @activelog where log_id = @logID ";
                        SqlCommand myCommand = new SqlCommand(query, con);

                        SqlParameter lActive = new SqlParameter("@activelog", SqlDbType.Bit);
                        SqlParameter lID = new SqlParameter("@logID", SqlDbType.Int);
                        lActive.Value = false;
                        lID.Value = log_id_remove;

                        myCommand.Parameters.Add(lID);
                        myCommand.Parameters.Add(lActive);

                        myCommand.Connection.Open();

                        Int32 returnFlag = (Int32)myCommand.ExecuteNonQuery();
                        if (returnFlag > 0)
                        {
                            refreshListView();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            catch(Exception ex) 
            {
                string mess = "Please select the log entry you wish to be removed.";
                string cap = "No Log Entry Selected";
                MessageBox.Show(this,mess,cap, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
                
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

            con.Close();
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

            listView1.Columns.Add("Log_Id", 0);
            listView1.Columns.Add("Date", 100);
            listView1.Columns.Add("Start", 100);
            listView1.Columns.Add("End", 100);
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
            String sel1 = "SELECT TimeLog.employee_id, TimeLog.startTime, TimeLog.endTime, TimeLog.breakTime, TimeLog.log_id FROM TimeLog where TimeLog.employee_id = '" + userClass.employee_id + "' AND TimeLog.activeLog = '"+ true +"'  ";
            SqlDataAdapter Da = new SqlDataAdapter(sel1, con1);
            DataSet ds = new DataSet();
            DataTable dt;

            Da.Fill(ds, "QueryResult_TimeLog");

            dt = ds.Tables["QueryResult_TimeLog"];
            con1.Close();
            int i;
            string[] starting;
            string[] ending;
            string log_id;
            listView1.Items.Clear();

            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                starting = dt.Rows[i].ItemArray[1].ToString().Split(' ');
                ending = dt.Rows[i].ItemArray[2].ToString().Split(' ');
                log_id = dt.Rows[i].ItemArray[4].ToString();

                listView1.Items.Add(log_id);
                listView1.Items[i].SubItems.Add(starting[0]);
                listView1.Items[i].SubItems.Add(starting[1] + " " + starting[2]);
                listView1.Items[i].SubItems.Add(ending[1] + " " + ending[2]);
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }


            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /*
         * Disabled the column width changing.
         */
        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
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

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }


 }

