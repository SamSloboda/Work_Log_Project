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

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" || tb_password.Text == "") 
            {
                MessageBox.Show("Please enter username and password!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                String cs = DatabaseConnect.connectionString;
                SqlConnection con = new SqlConnection(cs);

                string sel = "SELECT * FROM db_User WHERE username = @username AND password = @password";
                SqlCommand myCommand = new SqlCommand(sel, con); ;

                SqlParameter uName = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@password", SqlDbType.VarChar);

                uName.Value = tb_username.Text;
                uPassword.Value = tb_password.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();
 
                
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {                     
                    userClass currentUser = new userClass();
                    currentUser.user_id = myReader.GetInt32(0);
                    currentUser.username = myReader.GetString(1);
                    currentUser.password = myReader.GetString(2);
                    currentUser.adminAcc = myReader.GetBoolean(3);
                    currentUser.activeUser = myReader.GetBoolean(4);

                    MessageBox.Show("You have logged in successfully as: " + myReader.GetString(1));

                    

                    if (currentUser.adminAcc == true)
                    {
                        
                        EmployerForm employerForm = new EmployerForm();
                        employerForm.ShowDialog();
                        
                    }
                    if (currentUser.adminAcc == false)
                    {
                        
                        EmployeeForm employeeForm = new EmployeeForm();
                        employeeForm.ShowDialog();
                        
                    }


                }
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


            //Administrator adminn = new Administrator();
            //adminn.ShowDialog();

            

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
            public static String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sam Sloboda\\source\\repos\\Work_Log_Project\\db_WorkLog.mdf;Integrated Security = True";

            //MOMO's connection string bellow
            //public static String connectionString = "INSERT YOUR CONNECTION STRING HERE";

            //SAMON's connection string bellow
            //public static String connectionString = "INSERT YOUR CONNECTION STRING HERE";

            DatabaseConnect() { }
        }
    }

}
