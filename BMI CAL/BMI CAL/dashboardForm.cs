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
using System.Windows.Forms.DataVisualization.Charting;

namespace BMI_CAL
{
    public partial class dashboardForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BMI CALv3\BMI CAL\Database1.mdf;Integrated Security=True");
        public static string username;
        public dashboardForm()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //resets all data currently entered
            idTextBox.Text = "";
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            bmiResult.Text = "";
            dateOfReading.Text = "";
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "")
            {
                MessageBox.Show("Please enter a value for reading Id","BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateOfReading.Text == "")
            {
                MessageBox.Show("Please enter a value for date of reading", "BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (heightTextBox.Text == "")
            {
                MessageBox.Show("Please enter a value for height", "BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (weightTextBox.Text == "")
            {
                MessageBox.Show("Please enter a value for weight", "BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double height, weight, bmi;
                weight = double.Parse(weightTextBox.Text);
                height = double.Parse(heightTextBox.Text);
                bmi = weight / ((height / 100.0) * (height / 100.0));
                bmiResult.Text = bmi.ToString("n");

                con.Open();
                string query = "insert into bmidata (Id, date, weight, height, bmi, userName) values('" + idTextBox.Text + "','" + dateOfReading.Text + "','" + weightTextBox.Text + "','" + heightTextBox.Text + "','" + bmiResult.Text + "', '" + BMI.username + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Calculated and Inserted Successfully", "BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new BMI().Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label7.Text = BMI.username;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select date, bmi from bmidata",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            chart1.DataSource = dt;
            con.Close();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BMI logform = new BMI();
            logform.Show();
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from bmidata where Id = '"+idTextBox.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data deleted", "BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from bmidata";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bmidataDataGridView.DataSource = dt;
            con.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update bmidata set date = '" + dateOfReading.Text + "', weight = '" + weightTextBox.Text + "', height = '" + heightTextBox.Text + "', bmi = '" + bmiResult.Text + "' where Id = '" + idTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been Updated!", "BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bmidataDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idTextBox.Text = bmidataDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            dateOfReading.Text = bmidataDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            weightTextBox.Text = bmidataDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            heightTextBox.Text = bmidataDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            bmiResult.Text = bmidataDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            BMI.username = bmidataDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void bmichartButton_Click(object sender, EventArgs e)
        {
            bmichart bmiChart = new bmichart();
            bmiChart.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.bmidataTableAdapter.SearchDate(
                this.database1DataSet1.bmidata, searchBox.Text);
        }

        private void savechartButton_Click_1(object sender, EventArgs e)
        {
            this.chart1.SaveImage("C:\\Users\\Brandon\\Desktop\\mychart.png", ChartImageFormat.Png);
            MessageBox.Show("Chart has been saved", "BMI Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application allows users to check what their current BMI is, record that data on a chart and track their progress throughout the weeks");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the data then hit calculate to see what your BMI is and the program will automatically add all of this data into a database for further recording");
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
