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

        public OleDbCommand cmd { get; private set; }

       // public Print_Invoice(string firstname, string surname, string address, string phonenumber, string destination, string flightprice, string hotellocation, string hotelprice, string carhirePrice)
       // {
       //     InitializeComponent();
       //     fnameLbl.Text = firstname;
       //     snameLbl.Text = surname;
       //     addrLbl.Text = address;
       //     phonenumLbl.Text = phonenumber;
       //     destiLbl.Text = destination;
        //    fliprice = flightprice;
        //    carpriceLbl.Text = carhirePrice;
        //    locatLbl.Text = hotellocation;
       //     htlpri = hotelprice;
        //}

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
            sb.AppendLine(Locationinput.Text);
            sb.AppendLine(DateTimePicker1.Text);
            sb.AppendLine(label4.Text);
            sb.AppendLine(Avaoutput.Text);
            sb.AppendLine(label1.Text);
            sb.AppendLine(Seatoutput.Text);
            //flight details
            sb.AppendLine(Flightdetails.Text);
            sb.AppendLine(label5.Text);
            sb.AppendLine(Flightnum.Text);
            sb.AppendLine(label6.Text);
            sb.AppendLine(Flighttype.Text);
            sb.AppendLine(label7.Text);
            sb.AppendLine(Departure.Text);
            sb.AppendLine(label8.Text);
            sb.AppendLine(Destination.Text);
            sb.AppendLine(label10.Text);
            sb.AppendLine(Departuretime.Text);
            sb.AppendLine(label9.Text);
            sb.AppendLine(Arrivaltime.Text);
            sb.AppendLine(label11.Text);
            sb.AppendLine(Adultprice.Text);
            sb.AppendLine(label12.Text);
            sb.AppendLine(Childprice.Text);
            //Car hire details
            sb.AppendLine(Cardetails.Text);
            sb.AppendLine(Carinput.Text);
            sb.AppendLine(label18.Text);
            sb.AppendLine(Numplate.Text);
            sb.AppendLine(label19.Text);
            sb.AppendLine(Make.Text);
            sb.AppendLine(label20.Text);
            sb.AppendLine(Model.Text);
            sb.AppendLine(label21.Text);
            sb.AppendLine(Gearbox.Text);
            sb.AppendLine(label22.Text);
            sb.AppendLine(Seats.Text);
            sb.AppendLine(label23.Text);
            sb.AppendLine(Priceperday.Text);
            //hotel details
            sb.AppendLine(Hoteldetails.Text);
            sb.AppendLine(Hotelinput.Text);
            sb.AppendLine(label13.Text);
            sb.AppendLine(Starrating.Text);
            sb.AppendLine(label14.Text);
            sb.AppendLine(Checkin.Text);
            sb.AppendLine(label15.Text);
            sb.AppendLine(Checkout.Text);
            sb.AppendLine(label16.Text);
            sb.AppendLine(Pricepernight.Text);
            //total
            sb.AppendLine(label24.Text);
            sb.AppendLine(textBox1.Text);
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
            Seatoutput.Text = Back_End.Program.calculations.spacesTaken(Avaoutput.Text);
        }

        private void Locationinput_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Cardetails_Enter(object sender, EventArgs e)
        {

        }

        private void Hoteldetails_Enter(object sender, EventArgs e)
        {

        }

        private void Availability_Check_Load(object sender, EventArgs e)
        {
            //check for recovery Avar
            Back_End.SecondaryDatabase.notifyRecovery();

            {
              //destnation check to database  
                OleDbCommand command = new OleDbCommand();

                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Primary.mdb";
                command.Connection = connection;

                connection.Open();

                string query = "SELECT Destination FROM Flights";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    Locationinput.Items.Add(reader["Destination"].ToString());

                //string query = "SELECT CarType FROM Cars";
                //command.CommandText = query;


                //while (reader.Read())
                //Carinput.Items.Add(reader["CarType"].ToString());

            }

            {
                //
                //OleDbCommand command = new OleDbCommand();

                //connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Primary.mdb";
                //command.Connection = connection;

                //connection.Open();

                //string query = "SELECT Destination FROM Flights";
                //command.CommandText = query;

                //OleDbDataReader reader = command.ExecuteReader();

                //while (reader.Read())
                    //Locationinput.Items.Add(reader["Destination"].ToString());


            }

        }

        private void Carhireinput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Hotelinput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
