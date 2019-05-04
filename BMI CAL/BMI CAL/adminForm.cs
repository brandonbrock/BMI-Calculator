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
    public partial class adminForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BMI CALv3\BMI CAL\Database1.mdf;Integrated Security=True");
        public adminForm()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            string title = "Close Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //return to program
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BMI logform = new BMI();
            logform.Show();
        }

        private void userdataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userdataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            MessageBox.Show("DATA SAVED");

        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.userdata' table. You can move, or remove it, as needed.
            this.userdataTableAdapter.Fill(this.database1DataSet.userdata);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }
    }
}
