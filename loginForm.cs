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
    
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        //for form movement
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        /**
         * The function is invoked with click event of Login button.
         */
        private void bt_login_Click(object sender, EventArgs e)
        {
            ///checks if user inputs empty string into textBoxes
            if (tb_username.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("Please enter username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    ///creates connection string and creates connection
                    String cs = DatabaseConnect.connectionString;
                    SqlConnection con = new SqlConnection(cs);

                    ///select all the users that match password and username
                    string sel = "select * FROM db_User where username = @username AND password = @password AND activeUser = @activeuser ";
                    SqlCommand myCommand = new SqlCommand(sel, con); ;

                    ///parameters for the sel command above
                    SqlParameter uName = new SqlParameter("@username", SqlDbType.VarChar);
                    SqlParameter uPassword = new SqlParameter("@password", SqlDbType.VarChar);
                    SqlParameter uActive = new SqlParameter("@activeuser", SqlDbType.Bit);

                    ///assigning values from the textboxes into parameters
                    uName.Value = tb_username.Text;
                    uPassword.Value = tb_password.Text;
                    uActive.Value = true; //user is active

                    ///adding paramaters to the command
                    myCommand.Parameters.Add(uName);
                    myCommand.Parameters.Add(uPassword);
                    myCommand.Parameters.Add(uActive);

                    ///opening connection
                    myCommand.Connection.Open();

                    ///reader class for database  
                    SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                    ///if the username and password was found in database return true
                    if (myReader.Read() == true)
                    {
                        ///assigning values of user to the userClass class.
                        userClass.user_id = myReader.GetInt32(0);
                        userClass.username = myReader.GetString(1);
                        userClass.password = myReader.GetString(2);
                        userClass.adminAcc = myReader.GetBoolean(3);
                        userClass.activeUser = myReader.GetBoolean(4);

                        ///if admin
                        if (myReader.GetBoolean(3) == true)
                        {
                            MessageBox.Show("You have logged in successfully as: Admin " + userClass.username, "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tb_password.Text = "";                            
                            
                            WelcomeAdmin form = new WelcomeAdmin();
                            form.ShowDialog();

                        }
                        ///if normal employee account
                        if (myReader.GetBoolean(3) == false)
                        {
                            MessageBox.Show("You have logged in successfully as: User " + userClass.username, "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tb_password.Text = "";
                            ///showing employeeForm

                            EmployeeForm employeeForm = new EmployeeForm();
                            employeeForm.ShowDialog();
                        }
                    }
                    else
                    {
                        ///if the username and password doesn't match with all the users found in database
                        MessageBox.Show("Incorrect name or password!", "Incorect Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ///if the connection is still present close the connection with database
                    if (con.State == ConnectionState.Open)
                    {
                        con.Dispose();
                        con.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
            

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
       
        public class DatabaseConnect
        /**
        * @momo; @samon => Just add your connection string, and comment out the others. DO NOT DELETE OTHERS CONNECTION STRING!
        */

        {
            //SAM's connection string bellow
          //  public static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sam Sloboda\\source\\repos\\Work_Log_Project\\db_WorkLog.mdf;Integrated Security = True";

            //MOMO's connection string bellow
            //public static String connectionString = ""Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Source\\Repos\SamSloboda\\Work_Log_Project\\db_WorkLog.mdf;Integrated Security = True";

            //SAMON's connection string bellow
            public static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\samon\\Desktop\\CIS302LastAssignment\\db_WorkLog.mdf;Integrated Security = True";

            DatabaseConnect() { }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }

}
