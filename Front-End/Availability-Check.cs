﻿using System;
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


        public Availability_Check()
        {
            InitializeComponent();
        }


        private void nxtButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(Adultprice.Text);
                int num2 = Convert.ToInt32(Childprice.Text);
                int totalFlightPrice = num1 + num2;
                Booking_Reservation bookingRes = new Booking_Reservation(DateTimePicker1.Text, Flightnum.Text,
                    Flighttype.Text, Departuretime.Text, Arrivaltime.Text, numericUpDown1.ToString(), numericUpDown2.ToString(),
                    Locationinput.Text, totalFlightPrice.ToString(), Numplate.Text, Seats.Text, Make.Text, Model.Text,
                    Priceperday.Text, Carinput.Text, Starrating.Text, Checkin.Text, Checkout.Text,
                    Hotelinput.Text, Pricepernight.Text, Total.Text);
                bookingRes.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please check that all fields have been completed.");
            }
           
        }

      
        private void cnlButton_Click_2(object sender, EventArgs e)
        {
            //exit button code
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

            // code for copy button copying all text on the page to save progress if needed 
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
            sb.AppendLine(numericUpDown1.Text);
            sb.AppendLine(label12.Text);
            sb.AppendLine(Childprice.Text);
            sb.AppendLine(numericUpDown2.Text);
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
            sb.AppendLine(label3.Text);
            sb.AppendLine(numericUpDown3.Text);
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
            sb.AppendLine(numericUpDown4.Text);
            //total
            sb.AppendLine(label24.Text);
            sb.AppendLine(Total.Text);
            Clipboard.SetText(sb.ToString());
        }

        private void Avaoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seatoutput_TextChanged(object sender, EventArgs e)
        {

        }


        private void Flightdetails_Enter_1(object sender, EventArgs e)
        {

        }

        private void Check_Click_1(object sender, EventArgs e)
        {
            //retrieves flight details from database 

            try 
            {

                //Sing : Get flightID
                string flightID = Back_End.Program.calculations.getFlightID(Locationinput.Text);
                string date = DateTimePicker1.Text.ToString();
                //Sing: Display flight Details 
                var flightDetails = Back_End.DatabaseQuery.getFlightDetails(flightID, date);
                Flightnum.Text = flightDetails.flightNumber;
                Destination.Text = flightDetails.destination;
                Flighttype.Text = flightDetails.flightType;
                Departuretime.Text = flightDetails.departure;
                Departure.Text = flightDetails.departure;
                Arrivaltime.Text = flightDetails.arrival;
                Adultprice.Text = flightDetails.adultPrice;
                Childprice.Text = flightDetails.childPrice;

                //Sing: Check availability  
                if (Flightnum.Text != "")
                {
                    Avaoutput.Text = Back_End.Program.calculations.calculateSpacesLeft(flightID, date);
                    Seatoutput.Text = Back_End.Program.calculations.spacesTaken(Avaoutput.Text);
                }

            }
            catch
            {
                MessageBox.Show("Please Select a location");
            }

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
              //pulls flight destinations from database  
                OleDbCommand command = new OleDbCommand();

                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=PrimaryDB.mdb";
                command.Connection = connection;

                connection.Open();

                string query = "SELECT Destination FROM Flights";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    Locationinput.Items.Add(reader["Destination"].ToString());

                connection.Close();

                //pulls car rental service names from database  

                connection.Open();

                string query2 = "SELECT CarRentalCompany FROM Cars";
                command.CommandText = query2;

                OleDbDataReader reader2 = command.ExecuteReader();

                while (reader2.Read())
                Carinput.Items.Add(reader2["CarRentalCompany"].ToString());

                connection.Close();

                //pulls hotel names from database  

                connection.Open();

                string query3 = "SELECT HotelName FROM Hotel";
                command.CommandText = query3;

                OleDbDataReader reader3 = command.ExecuteReader();

                while (reader3.Read())
                    Hotelinput.Items.Add(reader3["HotelName"].ToString());

                connection.Close();

            }

           

        }

        private void Carhireinput_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sing: display car hire details
            var carDetails = Back_End.DatabaseQuery.getCarDetails(Carinput.Text);
            Numplate.Text = carDetails.numPlate;
            Gearbox.Text = carDetails.gearBox;
            Make.Text = carDetails.carMake;
            Seats.Text = carDetails.seats;
            Model.Text = carDetails.carModel;
            Priceperday.Text = carDetails.pricePerDay;
        }

        private void Hotelinput_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sing: Display hotel details
            var hotelDetails = Back_End.DatabaseQuery.getHotelDetails(Hotelinput.Text);
            Starrating.Text = hotelDetails.rating;
            Checkin.Text = hotelDetails.checkIn;
            Checkout.Text = hotelDetails.checkOut;
            Pricepernight.Text = hotelDetails.pricePerNight;
        }

       

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //adds price of adult tickets up

                //Sing : Get flightID
                string flightID = Back_End.Program.calculations.getFlightID(Locationinput.Text);
                string date = DateTimePicker1.Text.ToString();
                //Sing: Display flight Details 
                var flightDetails = Back_End.DatabaseQuery.getFlightDetails(flightID, date);

                //times price by value in numericupdown

                decimal x = numericUpDown1.Value;

                string strprice = flightDetails.adultPrice;
                decimal price = Convert.ToDecimal(strprice);

                decimal total = x * price;

                Adultprice.Text = total.ToString();
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please make sure flight detination and date have been selected. Then please click the 'Check' button.");
            }
            

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //adds price of child tickets up

            //Sing : Get flightID
            string flightID = Back_End.Program.calculations.getFlightID(Locationinput.Text);
            string date = DateTimePicker1.Text.ToString();
            //Sing: Display flight Details 
            var flightDetails = Back_End.DatabaseQuery.getFlightDetails(flightID, date);

            //times price by value in numericupdown

            decimal x = numericUpDown2.Value;

            string strprice = flightDetails.childPrice;
            decimal price = Convert.ToDecimal(strprice);

            decimal total = x * price;

            Childprice.Text = total.ToString();
        }

        private void Adultprice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Childprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Priceperday_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //adds up price per day for car rental 

            var carDetails = Back_End.DatabaseQuery.getCarDetails(Carinput.Text);

            Priceperday.Text = carDetails.pricePerDay;

            //times price by value in numericupdown

            decimal x = numericUpDown3.Value;

            string strprice = carDetails.pricePerDay;
            decimal price = Convert.ToDecimal(strprice);

            decimal total = x * price;

            Priceperday.Text = total.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            //adds up price per night for hotel rooms 

            var hotelDetails = Back_End.DatabaseQuery.getHotelDetails(Hotelinput.Text);

            Pricepernight.Text = hotelDetails.pricePerNight;

            //times price by value in numericupdown

            decimal x = numericUpDown4.Value;

            string strprice = hotelDetails.pricePerNight;
            decimal price = Convert.ToDecimal(strprice);

            decimal total = x * price;

            Pricepernight.Text = total.ToString();

        }

        private void Caculate_Click(object sender, EventArgs e)
        {
            //totals up all prices on page to give a overall price 

            try
            {

                int num1, num2, num3, num4, res;
                num1 = Convert.ToInt32(Adultprice.Text);
                num2 = Convert.ToInt32(Childprice.Text);
                num3 = Convert.ToInt32(Priceperday.Text);
                num4 = Convert.ToInt32(Pricepernight.Text);
                res = num1 + num2 + num3 + num4;
                Total.Text = Convert.ToString(res);

            }
            catch
            {
                MessageBox.Show("Please Select a car hire company and hotel company");
            }

        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
