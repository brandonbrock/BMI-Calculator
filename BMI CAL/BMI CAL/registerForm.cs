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

namespace BMI_CAL
{
    public partial class registerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BMI CALv3\BMI CAL\Database1.mdf;Integrated Security=True");
        string Gender;
        public registerForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                MessageBox.Show("Please enter a value for username", "BMI Calculator Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name.Text == "")
            {
                MessageBox.Show("Please enter a value for name", "BMI Calculator Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (surname.Text == "")
            {
                MessageBox.Show("Please enter a value for surname", "BMI Calculator Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (gender_female.Checked == false && gender_male.Checked == false)
            {
                MessageBox.Show("Please check a gender", "BMI Calculator Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateOfBirth.Text == "")
            {
                MessageBox.Show("Please enter a value for date of birth", "BMI Calculator Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bloodType.Text == "")
            {
                MessageBox.Show("Please enter a value for bloodtype", "BMI Calculator Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password_1.Text == "")
            {
                MessageBox.Show("Please enter a value for password", "BMI Calculator Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password_2.Text == "")
            {
                MessageBox.Show("Please enter a value for confirm password", "BMI Calculator Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password_1.Text != password_2.Text)
            {
                MessageBox.Show("Passwords don't match","BMI Calculator Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BMI CALv3\BMI CAL\Database1.mdf;Integrated Security=True"));
                {
                    con.Open();
                    bool accountExist = false;

                    //checks if username exists
                    using (SqlCommand cmd = new SqlCommand("select count(*) from userdata where username = @username", con))
                    {
                        cmd.Parameters.AddWithValue("username", username.Text);
                        accountExist = (int)cmd.ExecuteScalar() > 0;
                    }
                    //if account exists
                    if (accountExist)
                    {
                        MessageBox.Show("Username has been taken, try a different username", "BMI Calculator Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        String str = "insert into userdata(username, name, surname, gender, dateofbirth, bloodtype, password_1, password_2) values('" + username.Text + "','" + name.Text + "','" + surname.Text + "', '" + Gender + "' ,'" + dateOfBirth.Text + "','" + bloodType.Text + "','" + password_1.Text + "','" + password_2.Text + "')";
                        SqlCommand cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You are registered, thank you!", "BMI Calculator Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new BMI().Show();
                        this.Hide();
                    }
                }
            }

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

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            BMI logform = new BMI();
            logform.Show();

        }

        private void registerForm_Load(object sender, EventArgs e)
        {
        }

        private void gender_male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void gender_female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
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