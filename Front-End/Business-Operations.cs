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

namespace Front_End
{
    public partial class Business_Operations : Form
    {
        SqlConnection con = new SqlConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C: \Users\giann\Source\Repos\sebfuoco\System - Integration\Front - End\Holiday Booking System NEW.mdb"");
        public Business_Operations()
        {
            InitializeComponent();
        }

        private void extButton_Click(object sender, EventArgs e)
        {
            const string text = "Do you want to exit? This will redirect you to the starting page.";
            const string caption = "EXIT";
            var result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                main m = new main();
                m.ShowDialog();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Business_Operations_Load(object sender, EventArgs e)
        {
            disp_data();
            // TODO: This line of code loads data into the 'basic_Customer_Details.CustomerDetails' table. You can move, or remove it, as needed.
            this.customerDetailsTableAdapter.Fill(this.basic_Customer_Details.CustomerDetails);
            // TODO: This line of code loads data into the 'holiday_Booking_System_NEWDataSet.CustomerInfo' table. You can move, or remove it, as needed.
            this.customerInfoTableAdapter.Fill(this.holiday_Booking_System_NEWDataSet.CustomerInfo);

        }

        private void Insertbttn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table1 values('"+idtxt.Text+"','"+titletxt.Text+"','"+firstnametxt.Text+"','"+surnametxt.Text+"','"+gendertxt.Text+"','"+agetxt.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            idtxt.Text = "";
            titletxt.Text = "";
            firstnametxt.Text = "";
            surnametxt.Text = "";
            gendertxt.Text = "";
            agetxt.Text = "";
            disp_data();
            MessageBox.Show("Data Insert Successful");

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            con.Close();
        }

        private void deletebttn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from table1 where name='" +idtxt.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Data Successfully Deleted");
        }

        private void updatebttn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update table1 set name='"+surnametxt.Text+"'where name='" + firstnametxt.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Data Update Complete");
        }

        private void displaybttn_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void searchbttn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from table1 where name='"+idtxt.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
