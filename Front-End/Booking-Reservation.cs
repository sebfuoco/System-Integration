using Back_End;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// Kevin
// Requires user input after selecting the items
// Linked to previous page (Availability check/Query)


namespace Front_End
{
    public partial class Booking_Reservation : Form
    {

        //Booking Details Structure:
        struct bookingDetails
        {
            public string bookingDate;
            public string fname;
            public string sname;
            public string customerAddress;
            public string customerPhone;
            public string gender;
            public string nationality;
            public string passportNum;
            public string postCode;
            public string email;

            public string flightNumber;
            public string flightType;
            public string Departuretime;
            public string arrivalTime;
            public string numAdults;
            public string numChild;
            public string flightDestination;
            public string flightTotalPrice;

            public string carNumPlate;
            public string carSeats;
            public string carMake;
            public string carModel;
            public string carHirePrice;
            public string carHireName;

            public string hotelStar;
            public string hotelCheckin;
            public string hotelCheckout;
            public string hotelName;
            public string hotelTotalPrice;

            public string totalPrice;

        }
        //Instatiate bookingDetails
        bookingDetails booking = new bookingDetails();

            public Booking_Reservation(string date,string flightnumber,string flighttype,
                string flightdeparture,string flightarrival,string adults,
                string child,string destination, string flightTotalPrice, string numberPlate,
                string carSeats,string make,string model,string hirePrice,
                string hireName,string hotelStarRating,string checkIn,
                string checkOut,string hotelName,string hotelPrice,string totalPrice)
        {
            InitializeComponent();
            //Assign data from the previous form to the structure

            booking.bookingDate = date;
            booking.flightNumber = flightnumber;
            booking.flightType = flighttype;
            booking.Departuretime = flightdeparture;
            booking.arrivalTime = flightarrival;
            booking.numAdults = adults;
            booking.numChild = child;
            booking.flightDestination = destination;
            booking.flightTotalPrice = flightTotalPrice;
            booking.carNumPlate = numberPlate;
            booking.carSeats = carSeats;
            booking.carMake = make;
            booking.carModel = model;
            booking.carHirePrice = hirePrice;
            booking.carHireName = hireName;
            booking.hotelStar = hotelStarRating;
            booking.hotelCheckin = checkIn;
            booking.hotelCheckout = checkOut;
            booking.hotelName = hotelName;
            booking.hotelTotalPrice = hotelPrice;
            booking.totalPrice = totalPrice;
        }

        private void nxtButton_Click(object sender, EventArgs e)
        {
            // Basic validation which will notify the user if they have added invalid characters
            if (!Regex.IsMatch(firstNametxtbox.Text, @"^[a-zA-Z0]+$"))
            {
                MessageBox.Show("First name can not be empty or contains numbers and symbol");
            }

            else if (!Regex.IsMatch(lastNametxtbox.Text, @"^[a-zA-Z0]+$"))
            {
                MessageBox.Show("Last name can not be empty or contains numbers and symbol");
            }

            else if (!Regex.IsMatch(gendertxtbox.Text, @"^[a-zA-Z0]+$"))
            {
                MessageBox.Show("Gender can not be empty or contains numbers and symbol");
            }

            else if (!Regex.IsMatch(passportNumbtxtbox.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Passport number can not be empty or contains symbol");
            }

            else if (!Regex.IsMatch(Nationalitytxtbox.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Nationality can not be empty or contains symbol");
            }

            else if (!Regex.IsMatch(Addresstxtbox.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Address can not be empty or contains symbol");
            }

            else if (!Regex.IsMatch(postCodetxtbox.Text, @"^[a-zA-Z0-9]{7,8}\b+$"))
            {
                MessageBox.Show("Post code can not be empty or contains symbols");
            }
  
            else if (!Regex.IsMatch(contactNumbertxtbox.Text, @"(\+?( |-|\.)?\d{1,2}( |-|\.)?)?(\(?\d{3}\)?|\d{3})( |-|\.)?(\d{3}( |-|\.)?\d{4})"))
            {
                MessageBox.Show("Contact number can not be empty or contain letters or symbols");
            }

            else if (!Regex.IsMatch(emailtxtbox.Text, @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$"))
            {
                MessageBox.Show("Must be a valid email address");
            }
            else
            {
                // Connects to the database
                string cString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PrimaryDB.mdb";

                // SQL query that will insert customer details to the database
                string save = "INSERT INTO Customers (CustomerFirstName, CustomerLastName, Gender, PassportNumber, Nationality, Address, PostCode, ContactNumber, EmailAddress) " +
                "VALUES (@CustomerFirstName, @CustomerLastName, @Gender, @PassportNumber, @Nationality, @Address, @PostCode, @ContactNumber, @EmailAddress)";

                // Objects it requires
                object[] customers = {"@CustomerFirstName", firstNametxtbox.Text, "@CustomerLastName", lastNametxtbox.Text, "@Gender", gendertxtbox.Text,
                        "@PassportNumber", passportNumbtxtbox.Text, "@Nationality", Nationalitytxtbox.Text, "@Address", Addresstxtbox.Text, "@PostCode",
                    postCodetxtbox.Text, "@ContactNumber", contactNumbertxtbox.Text, "@EmailAddress", emailtxtbox.Text};
                try
                {
                    // Function to write to database using the variables
                    var dbFunc = new DatabaseFunctions();
                    dbFunc.writeDatabase(save, cString, customers);
                    MessageBox.Show("Booking Reserved");
                    this.Hide();
                    booking.fname = firstNametxtbox.Text;
                    booking.sname = lastNametxtbox.Text;
                    booking.customerAddress = Addresstxtbox.Text;
                    booking.customerPhone = contactNumbertxtbox.Text;
                    booking.gender = gendertxtbox.Text;
                    booking.passportNum = passportNumbtxtbox.Text;
                    booking.nationality = Nationalitytxtbox.Text;
                    booking.postCode = postCodetxtbox.Text;
                    booking.email = emailtxtbox.Text;
                    Booking_Confirmation b = new Booking_Confirmation(booking.bookingDate, booking.fname, booking.sname,
                        booking.customerAddress, booking.customerPhone, booking.gender, booking.nationality,
                        booking.passportNum, booking.postCode, booking.email, booking.flightNumber,
                        booking.flightType, booking.Departuretime, booking.arrivalTime, booking.numAdults,
                        booking.numChild, booking.flightDestination, booking.flightTotalPrice,booking.carNumPlate,
                        booking.carSeats, booking.carMake, booking.carModel, booking.carHirePrice, booking.carHireName,
                        booking.hotelStar, booking.hotelCheckin, booking.hotelCheckout, booking.hotelName, booking.hotelTotalPrice, booking.totalPrice);
                    b.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred. Please contact the system administrator");
                }
            }
        }

        private void cnlButton_Click(object sender, EventArgs e)
        {
            // Goes back to the homepage
            const string text = "Are you sure want to cancel? This will delete your progress.";
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

        private void bckButton_Click(object sender, EventArgs e)
        {
            // Goes back a page
            this.Hide();
            Availability_Check a = new Availability_Check();
            a.ShowDialog();
        }

        private void extButton_Click(object sender, EventArgs e)
        {
            // Closes the program
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
    }
}
