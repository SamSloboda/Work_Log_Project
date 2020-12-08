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

       

    

        private void bt_clear_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bt_submit_Click_1(object sender, EventArgs e)
        {
            //Creating local variables to operate
            
            string connectionstring = loginForm.DatabaseConnect.connectionString;
            
        
            //Checking if the textboxes are empty!
            Boolean notComplete = ((tb_firstname.Text.Length==0) || (tb_lastname.Text.Length == 0) || (tb_username.Text.Length == 0) || (tb_password.Text.Length ==0) || (tb_confirmpassword.Text.Length== 0));
            //Checks for Password matching
            Boolean passwordMatch = (tb_password.Text == tb_confirmpassword.Text);
            
            lb_alert.Visible = false;
            lb_alert2.Visible = false;

            // Lets get the connection to get Existing data! We want to compare our input with the existing data
            if (!notComplete&&passwordMatch)
            {
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


                //Storing them in list will make it easier for us to use contains method and find if there is any duplicate values.
                List<string> firstNames = new List<string>(table.Rows.Count);
                List<string> lastNames = new List<string>(table.Rows.Count);
                


                foreach (DataRow row in table.Rows)
                    firstNames.Add((string)row["firstName"]);
                foreach (DataRow row in table.Rows)
                    lastNames.Add((string)row["lastName"]);
               



          
                //Using Contains() method to check if we can see if the data matches
                Boolean inspectNames = firstNames.Contains(tb_firstname.Text) && lastNames.Contains(tb_lastname.Text);
                if (!inspectNames)
                {
                    //If the test passes, we will proceed to add our new record to the database
                    //Insertion Process'
                    //string connectionstring = loginForm.DatabaseConnect.connectionString;

                    
                    SqlConnection connection1 = new SqlConnection(connectionstring);
                    SqlCommand command1 = connection1.CreateCommand();
                    try
                    {
                        string newquery = "INSERT INTO db_User VALUES ('" + tb_username.Text + "', '" + tb_password.Text + "', " + Convert.ToByte(bt_admin.Checked)+ ", " + Convert.ToByte(bt_active.Checked)+ ");";
                        command1.CommandText = newquery;
                        connection1.Open();

                        Int32 returnFlag = (Int32)command1.ExecuteNonQuery();
                        if (returnFlag > 0)
                        {
                            command1.Dispose();
                            connection1.Close();


                        }
                        else
                        {
                            MessageBox.Show("Error in creating a user account. ");
                        }


                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message.ToString());
                    }
                   

                    //THis if statement checks if the new user created is admin or not. If not, a new employee number is generated as well.

                    if (!bt_admin.Checked)
                    {
                        SqlConnection connection12 = new SqlConnection(connectionstring);
                        SqlCommand command12 = connection12.CreateCommand();
                        try
                        {
                            string newquery = "INSERT INTO Employee (user_id, firstName, middleName, lastName, creationTime)  SELECT user_id, '" + tb_firstname.Text + "', '" + tb_middleName.Text + "', '" + tb_lastname.Text + "', GETDATE()  FROM db_User WHERE username = '" + tb_username.Text+ "' ;" ;
                            command12.CommandText = newquery;
                            connection12.Open();

                            Int32 returnFlag = (Int32)command12.ExecuteNonQuery();
                            if (returnFlag > 0)
                            {
                                MessageBox.Show("Record successfully created! The new User is added.", "Operation Successful!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Unfortunately, we couldnt process your data", "Bummer!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            command12.Dispose();
                            connection12.Close();

                        }

                        catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message.ToString());
                    }
                        
                }


                }

                else
                {
                    MessageBox.Show("Duplicate records found. Please check the records!", "Fatal Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }


            }
            else
            {
                if (notComplete )
                {
                    MessageBox.Show("Input Error. Please fill up all required fields. ", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lb_alert.Visible = true;
                    lb_alert2.Visible = true;
                }

            }
        }

        private void bt_clear_Click_1(object sender, EventArgs e)
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

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
