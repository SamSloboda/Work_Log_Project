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
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();

        }
        int userID;
        int employeeID;
        private void bt_submit_Click(object sender, EventArgs e)
        {


            String cs = loginForm.DatabaseConnect.connectionString;
            SqlConnection con1 = new SqlConnection(cs);

            if (tb_userNamefind.Text != "")
            {
                try
                {
                    String sel1 = "SELECT Employee.user_id, employee_id, firstName, middleName, lastName, username,password,adminAcc, activeUser FROM Employee JOIN db_User ON Employee.user_id=db_User.user_id  WHERE username ='" + tb_userNamefind.Text + "';";


                    SqlDataAdapter Da = new SqlDataAdapter(sel1, con1);
                    DataSet ds = new DataSet();
                    DataTable dt;

                    Da.Fill(ds, "QueryResult");

                    dt = ds.Tables["QueryResult"];

                    con1.Close();



                    int numrow = dt.Rows.Count;


                    DataRow row = dt.Rows[0];

                    tb_firstname.Text = row["firstName"].ToString();
                    tb_middlename.Text = row["middleName"].ToString();
                    tb_lastname.Text = row["lastName"].ToString();
                    tb_password.Text = row["password"].ToString();
                    tb_username.Text = row["username"].ToString();
                    userID = Int32.Parse(row["user_id"].ToString());
                    employeeID = Int32.Parse(row["employee_id"].ToString());

                    if (row["activeUser"].ToString() == "True")
                    {
                        bt_active.Checked = true;

                    }
                    if (row["adminAcc"].ToString() == "True")
                    {
                        bt_admin.Checked = true;
                    }
                }




                catch (Exception ex)
                {
                    MessageBox.Show("Records weren't found for given username!", "Unable to locate records", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } 
            
         }
            else
            {
                MessageBox.Show("Input type Mismatch!");
            }
                
                    
                


            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {

            tb_userNamefind.Text = "";
            tb_firstname.Text = "";
            tb_middlename.Text = "";
            tb_lastname.Text = "";
            tb_password.Text = "";
            tb_confirmpassword.Text = "";
            bt_active.Checked = false;
            bt_admin.Checked = false;
        }

        private void bt_submitchange_Click(object sender, EventArgs e)
        {
            string connectionstring = loginForm.DatabaseConnect.connectionString;


            //Checking if the textboxes are empty!
            Boolean notComplete = ((tb_firstname.Text.Length == 0) || (tb_lastname.Text.Length == 0) || (tb_username.Text.Length == 0) || (tb_password.Text.Length == 0) || (tb_confirmpassword.Text.Length == 0));
            //Checks for Password matching
            Boolean passwordMatch = (tb_password.Text == tb_confirmpassword.Text);


            // Lets get the connection to get Existing data! We want to compare our input with the existing data
            if (!notComplete && passwordMatch)
            {
                string query = "SELECT * FROM db_User";
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
                List<string> usernames = new List<string>(table.Rows.Count);




                foreach (DataRow row in table.Rows)
                    usernames.Add((string)row["username"]);





                //Using Contains() method to check if we can see if the data matches
                Boolean inspectNames = usernames.Contains(tb_username.Text);
                if (true)
                {
                    if (bt_admin.Checked)
                    {
                        //If the test passes, we will proceed to add our new record to the database
                        //Insertion Process'
                        //string connectionstring = loginForm.DatabaseConnect.connectionString;
                        

                        SqlConnection connection1 = new SqlConnection(connectionstring);
                        SqlCommand command1 = connection1.CreateCommand();
                        try
                        {
                            string newquery = "UPDATE db_User SET username = '" + tb_username.Text + "', password='" + tb_password.Text + "', adminAcc = " + Convert.ToByte(bt_admin.Checked) + ", activeUser =  " + Convert.ToByte(bt_active.Checked) + " WHERE user_id = " + userID+ ";";
                            command1.CommandText = newquery;
                            connection1.Open();

                            Int32 returnFlag = (Int32)command1.ExecuteNonQuery();
                            if (returnFlag > 0)
                            {
                                MessageBox.Show("Record updated! The new Admin is added.", "Operation Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Unfortunately, we couldnt process your data", "Bummer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            command1.Dispose();
                            connection1.Close();

                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message.ToString());
                        }
                    }


                    //THis if statement checks if the new user created is admin or not. If not, a new employee number is generated as well.

                    if (!bt_admin.Checked)
                    {

                        //If the test passes, we will proceed to add our new record to the database
                        //Insertion Process'
                        //string connectionstring = loginForm.DatabaseConnect.connectionString;
                        

                        SqlConnection connection1 = new SqlConnection(connectionstring);
                        SqlCommand command1 = connection1.CreateCommand();
                        try
                        {
                            {
                                string newquery = "UPDATE db_User SET username = '" + tb_username.Text + "', password='" + tb_password.Text + "', adminAcc = " + Convert.ToByte(bt_admin.Checked) + ", activeUser =  " + Convert.ToByte(bt_active.Checked) + " WHERE user_id = " + userID + ";"; command1.CommandText = newquery;
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
                                    command1.Dispose();
                                    connection1.Close();
                                }


                            }
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message.ToString());
                        }

                        SqlConnection connection12 = new SqlConnection(connectionstring);
                        SqlCommand command12 = connection12.CreateCommand();
                        try
                        {
                            string newquery = "UPDATE Employee  SET firstName = '" + tb_firstname.Text + "', middleName = '" + tb_middlename.Text + "', lastName = '" + tb_lastname.Text + "', creationTime = GETDATE()  WHERE employee_id =" + employeeID + ";";
                                
                            command12.CommandText = newquery;
                            connection12.Open();

                            Int32 returnFlag = (Int32)command12.ExecuteNonQuery();
                            if (returnFlag > 0)
                            {
                                MessageBox.Show("Record successfully Updated! The credentials are updated", "Operation Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Unfortunately, we couldnt process your data", "Bummer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (notComplete)
                {
                    MessageBox.Show("Input Error. Please fill up all required fields. ", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lb_error.Visible = true;
                    MessageBox.Show("The passwords are not matching!", "Password Mismatch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void bt_revert_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeAdmin admin = new WelcomeAdmin();
            admin.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
