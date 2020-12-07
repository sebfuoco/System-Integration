using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

// Availability Check/Query
// This form will check and allow user to select items for reservation

namespace Front_End
{

    public partial class Availability_Check : Form
    {

        //Sing : login database declarations
        System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection();
        OleDbDataAdapter ad;
        DataTable dtable = new DataTable();
        OleDbCommand command = new OleDbCommand();
        OleDbDataReader reader;
        
        //try {
        //    connection.open();
           
        //using(OleDbDataReader reader = command.ExecuteReader()) {  
        //                Console.WriteLine("");  
        //                while (reader.Read()) {  
        //                    Console.WriteLine("{0} {1}", reader["Name"].ToString(), reader["Address"].ToString());  
        //                                        }
        //                            }
        //    }

        public Availability_Check()
        {
            InitializeComponent();
        }


        private void nxtButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Booking_Reservation a = new Booking_Reservation();
            a.ShowDialog();
        }

        private void extButton_Click_1(object sender, EventArgs e)
        {
            const string text = "Do you want to exit?";
            const string caption = "EXIT";
            var result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cnlButton_Click_2(object sender, EventArgs e)
        {
            const string text = "Do you want to cancel? This will redirect you to the home page.";
            const string caption = "CANCEL";
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

        private void Copyb_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Avaoutput.Text);
            sb.AppendLine(Seatoutput.Text);
            sb.AppendLine(Flightdetails.Text);
            sb.AppendLine(Cardetails.Text);
            sb.AppendLine(Hoteldetails.Text);
            Clipboard.SetText(sb.ToString());

        }

        private void Avaoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seatoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Printb_Click(object sender, EventArgs e)
        {

        }

        private void Flightdetails_Enter_1(object sender, EventArgs e)
        {

        }

        private void Check_Click_1(object sender, EventArgs e)
        {
            string flightID = Back_End.Program.calculations.getFlightID(Locationinput.Text);
            string date = DateTimePicker1.Text.ToString();
            Avaoutput.Text = Back_End.Program.calculations.calculateSpacesLeft(flightID, date);
        }

        private void Locationinput_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           // string source = @"Data Source=Primary.mbd;Inital Catalog=Test;Integrated Security=true";
           // SqlConnection con = new SqlConnection(source);
           // con,open();

           // String sqlSelectQuery = "select Destination from Flights where ID = " + int.Parse(Locationinput_SelectedIndexChanged_1);
           // SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
           // SqlDataReader dr = cmd.ExecuteReader();
           // if (dr.Read())
            

            //SqlConneection con = new SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dev20\source\repos\System-Integration\Front-End\Primary.mdb");
            //con.open();

            // SqlCommand cmd = new SqlCommand("select Destination from Flights where = "+ int.Parse(Locationinput_SelectedIndexChanged_1);

        }

        private void Cardetails_Enter(object sender, EventArgs e)
        {

        }

        private void Hoteldetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
