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

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (tb_userNamefind.Text != "")
            {
                String cs = loginForm.DatabaseConnect.connectionString;
                SqlConnection con1 = new SqlConnection(cs);
                ///show all the ACTIVE timeLogs for the current user
                String sel1 = "SELECT * FROM Employee FULL OUTER JOIN db_User ON db_User.user_id=Employee.user_id where db_User.username="+tb_userNamefind.Text;

                SqlDataAdapter Da = new SqlDataAdapter(sel1, con1);
                DataSet ds = new DataSet();
                DataTable dt;

                Da.Fill(ds, "QueryResult");

                dt = ds.Tables["QueryResult"];
                con1.Close();

                string fName, mName, lName, pass;
                foreach (DataRow row in dt.Rows) 
                {
                    fName = row["firstName"].ToString();
                    mName = row["middleName"].ToString();
                    lName = row["lastName"].ToString();
                    pass = row["password"].ToString();
                    MessageBox.Show(fName + mName + lName + pass);

                }
                
                    
                


            }
            else 
            {
                MessageBox.Show("Please input something in the Username textbox! ", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
