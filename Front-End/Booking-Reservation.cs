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
        // Passing values from the previous page to another page. Commented out because the other booking-confirmation.cs does not have a place holder
        // public Print_Invoice(string firstname, string surname, string address, string phonenumber, string destination, string flightprice, string hotellocation, string hotelprice, string carhirePrice)
        // {
        //     InitializeComponent();
        //     firstNametxtbox.Text = firstname;
        //     lastNametxtbox.Text = surname;
        //     Addresstxtbox.Text = address;
        //     contactNumbertxtbox.Text = phonenumber;
        //     destiLbl.Text = destination;
        //    fliprice = flightprice;
        //    carpriceLbl.Text = carhirePrice;
        //    locatLbl.Text = hotellocation;
        //     htlpri = hotelprice;
        //}

        //Booking Details Structure:
        struct bookingDetails
        {
            public string bookingDate;
            public string fname;
            public string sname;
            public string customerAddress;
            public string customerPhone;
            public string flightDestination;
            public string flightTotalPrice;
            public string carHirePrice;
            public string hireDetails;
            public string hotelDetails;
            public string hotelTotalPrice;
            public string totalPrice;

        }
        //Instatiate bookingDetails
        bookingDetails booking = new bookingDetails();

        public Booking_Reservation(string date, string firstname, string surname, string address, string phonenumber, string destination, string flightprice,
                             string carDetails, string carhirePrice, string hotellocation, string hotelprice, string total)
        {
            InitializeComponent();
            //Assign data from the previous form to the structure
            booking.bookingDate = date;
            booking.fname = firstname;
            booking.sname = surname;
            booking.customerPhone = phonenumber;
            booking.customerAddress = address;
            booking.flightDestination = destination;
            booking.flightTotalPrice = flightprice;
            booking.hireDetails = carDetails;
            booking.carHirePrice = carhirePrice;
            booking.hotelDetails = hotellocation;
            booking.hotelTotalPrice = hotelprice;
            booking.totalPrice = total;

        }
        double mynum = 0;
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

            else if (!Regex.IsMatch(emailtxtbox.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Must be a valid email address");
            }
            else
            
            {
                // MessageBox.Show("Booking Reserved");


                // Connects to the database
                string cString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PrimaryDB.mdb";

                // SQL query that will insert customer details to the database
                string save = "INSERT INTO Customers (CustomerFirstName, CustomerLastName, Gender, PassportNumber, Nationality, Address, PostCode, ContactNumber, EmailAddress) " +
                "VALUES (@CustomerFirstName, @CustomerLastName, @Gender, @PassportNumber, @Nationality, @Address, @PostCode, @ContactNumber, @EmailAddress)";

                // Objects it requires
                object[] customers = {"@CustomerFirstName", firstNametxtbox.Text, "@CustomerLastName", lastNametxtbox.Text, "@Gender", gendertxtbox.Text,
                        "@PassportNumber", passportNumbtxtbox.Text, "@Nationality", Nationalitytxtbox.Text, "@Address", Addresstxtbox.Text, "@PostCode",
                    postCodetxtbox.Text, "@ContactNumber", contactNumbertxtbox.Text, "@EmailAddress", emailtxtbox.Text};

                // Function to write to database using the variables
                var dbFunc = new DatabaseFunctions();
                dbFunc.writeDatabase(save, cString, customers);

                this.Hide();
                Booking_Confirmation b = new Booking_Confirmation();
                b.ShowDialog();
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
