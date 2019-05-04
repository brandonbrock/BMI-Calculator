using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BMI_CAL
{
    public partial class BMI : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BMI CALv3\BMI CAL\Database1.mdf;Integrated Security=True");
        public static string username;
        public BMI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            string title = "Close Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                //return to program
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            con.Open();
            String str1 = "select * from userdata where username='" + log_username.Text + "' and password_1='" + log_password.Text + "'";
            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataAdapter da = new SqlDataAdapter(str1, con);
            da.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("You are logged in!", "BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username = log_username.Text;
                this.Hide();
                dashboardForm dashform = new dashboardForm();
                dashform.Show();

            }
            else if (log_username.Text == "admin" && log_password.Text == "admin")
            {
                MessageBox.Show("You are logged in!", "BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                adminForm admin = new adminForm();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong or Account doesn't exist!", "BMI Calculator Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerForm regform = new registerForm();
            regform.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application allows users to check what their current BMI is, record that data on a chart and track their progress throughout the weeks");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the data then hit calculate to see what your BMI is and the program will automatically add all of this data into a database for further recording");
        }
    }
}
